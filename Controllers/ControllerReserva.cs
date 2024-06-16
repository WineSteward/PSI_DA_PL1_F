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
        string fileName = "ObjectOProgramming";

        public ControllerReserva(CantinaContext db, MenuRefeicao Menu)
        {
            this.db = db;
            this.Menu = Menu;
        }

        //criar um talao (.txt) informacao do cliente e do menu dia/hora prato e extras
        public void MakeTalao(Reserva reserva)
        {
            fileName = reserva.GetFileName();

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
                if(listboxReservas.Items.Count > 0)
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

            if(reservaEscolhida.Cliente is Estudante)
                 novaFatura = new Fatura(reservaEscolhida.Menu.DataHora ,reservaEscolhida.Total, reservaEscolhida.Menu.precoEstudante, reservaEscolhida.Prato, reservaEscolhida.Extras);

            else
                novaFatura = new Fatura(reservaEscolhida.Menu.DataHora, reservaEscolhida.Total, reservaEscolhida.Menu.precoProfessor, reservaEscolhida.Prato, reservaEscolhida.Extras);
            
            GeneratePDF(novaFatura, fileName);
            db.SaveChanges();
        }

        public static void GeneratePDF(Fatura fatura, string fileName)
        {

            // Get the path to the user's Documents folder
            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(directoryPath, fileName);

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
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

            // Add items
            foreach (var item in fatura.Items)
            {
                Paragraph itemParagraph = new Paragraph($"Descricao do Item: {item.Descricao.PadRight(50)} Preco Item: {item.Preco:C}".PadRight(100));
                document.Add(itemParagraph);
            }

            // Add total
            Paragraph total = new Paragraph($"Total: {fatura.Total:C}");
            total.Alignment = Element.ALIGN_RIGHT;
            document.Add(total);

            document.Close();
        }


        public List<Cliente> UpdateListBoxClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            listaClientes = db.Estudantes.ToList<Cliente>();

            listaClientes.AddRange(db.Professores.ToList<Cliente>());

            return listaClientes;
        }

        public List<Extra> UpdateListBoxExtras(MenuRefeicao Menu)
        {

            listaExtras = Menu.Extras.ToList<Extra>();

            return listaExtras;
        }

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

