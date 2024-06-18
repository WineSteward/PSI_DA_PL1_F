using PSI_DA_PL1_F.Models;
using PSI_DA_PL1_F.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text.pdf.draw;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Bcpg.Sig;
using System.Diagnostics;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ControllerReserva : Controller
    {
        private CantinaContext db;
        private MenuRefeicao Menu;
        List<Prato> listaPratos;
        List<Extra> listaExtras;
        List<Extra> escolhaExtras;
        Multa multa;

        public ControllerReserva(CantinaContext db, MenuRefeicao Menu)
        {
            this.db = db;
            this.Menu = Menu;
        }

        //Cria um talao (.txt) informacao do cliente e do menu dia/hora prato e extras
        public void MakeTalao(Reserva reserva)
        {
            string fileName = reserva.GetFileName();

            // Get the content to save
            string content = reserva.ToStringExtended();

            // Write the content to a file
            File.WriteAllText(fileName, content);
        }

        public int AddReserva(Cliente cliente, Prato prato, CheckedListBox extras, ListBox listboxReservas)
        {

            if (Menu.Quantidade > 0)
            {
                //verificar se o menu ja passou
                if (Menu.DataHora < DateTime.Now)
                    return 3;


                //verificar  se o cliente ja tem uma reserva feita do menu selecionado
                if (listboxReservas.Items.Count > 0)
                {
                    foreach (Reserva reserva in listboxReservas.Items)
                    {
                        if (reserva.Cliente.Id == cliente.Id && reserva.Menu.Id == Menu.Id)
                            return -1;
                    }
                }

                //ir buscar os extras escolhidos pelo cliente
                escolhaExtras = MenuRefeicao.GetCheckedItems<Extra>(extras);

                //verificar que os extras nao excedem o limite de 3
                if (escolhaExtras.Count > 3)
                    return 4;

                decimal sumPrecoExtra = 0;

                //ir buscar todas as multas
                List<Multa> listaMultas = db.Multas.ToList<Multa>();


                foreach (Multa m in listaMultas)
                {
                    if ((Menu.DataHora - DateTime.Now) < TimeSpan.FromHours((int)m.NumeroHoras))
                    {
                        //nao sobrepor multa de valor inf com outra de valor supeior
                        if (multa == null)
                            // Se for uma DIFERENÇA INFERIOR ao numero de HORAS da MULTA ATUAL HA MULTA equivalente ao valor da multa atual
                            multa = new Multa(m.NumeroHoras, m.Valor);
                        else
                        {
                            if (multa.Valor > m.Valor)
                                continue;
                        }
                    }
                    // Se for uma DIFERENÇA SUPERIOR ao numero de HORAS da MULTA ATUAL NAO HA MULTA 
                }


                //verificar que tipo de cliente é
                //verificar se tem multa
                //verificar se conseguer pagar
                //return 1 consegue pagar com ou sem multa
                //return 2 nao consegue pagar
                //return 0 nao ha stock do menu
                if (cliente is Estudante)
                {
                    foreach (Extra extra in escolhaExtras)
                    {
                        sumPrecoExtra += extra.Valor;
                    }

                    if (multa != null)
                    {
                        if (cliente.Saldo >= Menu.precoEstudante + sumPrecoExtra + multa.Valor)
                        {
                            decimal total = Menu.precoEstudante + sumPrecoExtra + multa.Valor;

                            cliente.Saldo -= total;

                            Reserva novaReserva = new Reserva(cliente, multa, Menu, escolhaExtras, prato, total);

                            db.Reservas.Add(novaReserva);

                            this.MakeTalao(novaReserva);

                            Menu.Quantidade -= 1;

                            db.SaveChanges();

                            return 1;
                        }
                        else
                            return 2;
                    }
                    else
                    {
                        if (cliente.Saldo >= Menu.precoEstudante + sumPrecoExtra)
                        {
                            decimal total = Menu.precoEstudante + sumPrecoExtra;

                            cliente.Saldo -= total;

                            Reserva novaReserva = new Reserva(cliente, Menu, escolhaExtras, prato, total);

                            db.Reservas.Add(novaReserva);

                            this.MakeTalao(novaReserva);

                            Menu.Quantidade -= 1;

                            db.SaveChanges();

                            return 1;
                        }
                        else
                            return 2;
                    }
                }
                else
                {
                    if (multa != null)
                    {
                        if (cliente.Saldo >= Menu.precoProfessor + sumPrecoExtra + multa.Valor)
                        {
                            decimal total = Menu.precoProfessor + sumPrecoExtra + multa.Valor;
                            cliente.Saldo -= total;

                            Reserva novaReserva = new Reserva(cliente, multa, Menu, escolhaExtras, prato, total);

                            db.Reservas.Add(novaReserva);

                            this.MakeTalao(novaReserva);

                            Menu.Quantidade -= 1;

                            db.SaveChanges();

                            return 1;
                        }
                        else
                            return 2;
                    }
                    else
                    {
                        if (cliente.Saldo >= Menu.precoProfessor + sumPrecoExtra)
                        {
                            decimal total = Menu.precoProfessor + sumPrecoExtra;

                            cliente.Saldo -= total;

                            Reserva novaReserva = new Reserva(cliente, Menu, escolhaExtras, prato, total);

                            db.Reservas.Add(novaReserva);

                            this.MakeTalao(novaReserva);

                            Menu.Quantidade -= 1;

                            db.SaveChanges();

                            return 1;
                        }
                        else
                            return 2;
                    }
                }
            }
            else
                return 0;
        }

        public void AddSaldo(Cliente cliente, decimal adicionarSaldo)
        {
            cliente.Saldo += adicionarSaldo;
            db.SaveChanges();
        }


        public void ConsumirReserva(Reserva reservaEscolhida)
        {
            Fatura novaFatura;

            reservaEscolhida.Ativo = false;

            //Criar fatura apos consumo diferenciando que tipo de cliente é (precos diferentes)
            if (reservaEscolhida.Cliente is Estudante)
                novaFatura = new Fatura(reservaEscolhida.Menu.DataHora, reservaEscolhida.Total, reservaEscolhida.Menu.precoEstudante, reservaEscolhida.Prato, reservaEscolhida.Extras);

            else
                novaFatura = new Fatura(reservaEscolhida.Menu.DataHora, reservaEscolhida.Total, reservaEscolhida.Menu.precoProfessor, reservaEscolhida.Prato, reservaEscolhida.Extras);

            
            if(reservaEscolhida.Multa != null)
                GeneratePDF(novaFatura, reservaEscolhida.Multa);
           else
                GeneratePDF(novaFatura);


                db.SaveChanges();
        }

        public static void GeneratePDF(Fatura fatura)
        {

            try
            {

                //mudar este campo se mudar de maquina
                string directoryPath = @"C:\Users\MMC\Desktop\ObjectOProgramming\Projeto_Aplicacoes\PSI_DA_PL1_F\bin\Debug\Faturas";

                // Ensure the directory exists
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Combine directory path with a file name
                string fileName = "Fatura_" + fatura.Id + ".pdf";
                string filePath = Path.Combine(directoryPath, fileName);

                using (FileStream fstream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    Document document = new Document();
                    PdfWriter.GetInstance(document, fstream);
                    document.Open();

                    // Add title
                    Paragraph title = new Paragraph("Cantina");
                    title.Alignment = Element.ALIGN_CENTER;
                    document.Add(title);

                    // Add date
                    Paragraph date = new Paragraph($"Dia: {DateTime.Now:dd/MM/yyyy}");
                    date.Alignment = Element.ALIGN_LEFT;
                    document.Add(date);

                    // Add line separator
                    LineSeparator lineSeparator = new LineSeparator(1f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, -1);
                    document.Add(new Chunk(lineSeparator));


                    //variavel para encontrar o preco do prato
                    decimal precoPrato = fatura.Total;


                    //Add dos itens
                    foreach (var item in fatura.Items)
                    {
                        precoPrato -= item.Preco;
                        Paragraph itemParagraph = new Paragraph($"Descricao do Item: {item.Descricao.PadRight(50)} Preço Item: {item.Preco:C}".PadRight(100));
                        document.Add(itemParagraph);
                    }

                    //Add do prato
                    Paragraph prato = new Paragraph($"Descricao do Prato: {fatura.Prato.Descricao.PadRight(50)} Preço: {precoPrato:C}".PadRight(100));
                    document.Add(prato);

                    //adicionar nova linha separadora
                    document.Add(new Chunk(lineSeparator));

                    // Add total
                    Paragraph total = new Paragraph($"Total: {fatura.Total:C}");
                    total.Alignment = Element.ALIGN_RIGHT;
                    document.Add(total);

                    document.Close();
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error: Access to the path is denied. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        public static void GeneratePDF(Fatura fatura, Multa m)
        {

            try
            {
                //mudar este campo se mudar de maquina
                string directoryPath = @"C:\Users\MMC\Desktop\ObjectOProgramming\Projeto_Aplicacoes\PSI_DA_PL1_F\bin\Debug\Faturas";

                // Ensure the directory exists
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Combine directory path with a file name
                string fileName = "Fatura_" + fatura.Id + ".pdf";
                string filePath = Path.Combine(directoryPath, fileName);

                using (FileStream fstream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    Multa multa = m;

                    Document document = new Document();
                    PdfWriter.GetInstance(document, fstream);
                    document.Open();

                    // Add title
                    Paragraph title = new Paragraph("Cantina");
                    title.Alignment = Element.ALIGN_CENTER;
                    document.Add(title);

                    // Add date
                    Paragraph date = new Paragraph($"Dia: {DateTime.Now:dd/MM/yyyy}");
                    date.Alignment = Element.ALIGN_LEFT;
                    document.Add(date);

                    // Add line separator
                    LineSeparator lineSeparator = new LineSeparator(1f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, -1);
                    document.Add(new Chunk(lineSeparator));


                    //variavel para encontrar o preco do prato
                    decimal precoPrato = fatura.Total - multa.Valor;


                    //Add dos itens
                    foreach (var item in fatura.Items)
                    {
                        precoPrato -= item.Preco;
                        Paragraph itemParagraph = new Paragraph($"Descricao do Item: {item.Descricao.PadRight(50)} Preço Item: {item.Preco:C}".PadRight(100));
                        document.Add(itemParagraph);
                    }

                    //Add do prato
                    Paragraph prato = new Paragraph($"Descricao do Prato: {fatura.Prato.Descricao.PadRight(50)} Preço: {precoPrato:C}".PadRight(100));
                    document.Add(prato);


                    //Add do multa
                    Paragraph multaEscrita = new Paragraph($"Descricao do Prato: {multa.NumeroHoras.ToString().PadRight(50)} Preço: {multa.Valor:C}".PadRight(100));
                    document.Add(multaEscrita);


                    //adicionar nova linha separadora
                    document.Add(new Chunk(lineSeparator));

                    // Add total
                    Paragraph total = new Paragraph($"Total: {fatura.Total:C}");
                    total.Alignment = Element.ALIGN_RIGHT;
                    document.Add(total);

                    document.Close();
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error: Access to the path is denied. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }



        public List<Cliente> UpdateListBoxClientes()
        {
            List<Cliente> listaClientes = db.Estudantes.ToList<Cliente>();

            listaClientes.AddRange(db.Professores.ToList<Cliente>());

            return listaClientes;
        }

        public List<Extra> UpdateListBoxExtras(MenuRefeicao Menu)
        {

            listaExtras = Menu.Extras.ToList<Extra>();

            return listaExtras;
        }

        //Atualizar a lista de reservas que sejam do menu correto e que ainda nao foram consumidas (ativas)
        public List<Reserva> UpdateListBoxReservas(MenuRefeicao Menu)
        {
            List<Reserva> listaReservas = db.Reservas.Include(r => r.Extras)
                                                     .Where(r => r.Menu.Id == Menu.Id && r.Ativo == true)
                                                     .ToList();

            return listaReservas;
        }

        public List<Prato> UpdateListBoxPratos(MenuRefeicao menu)
        {

            listaPratos = menu.Pratos.ToList<Prato>();

            return listaPratos;
        }
    }
}

