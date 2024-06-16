using PSI_DA_PL1_F.Models;
using PSI_DA_PL1_F.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
               

                escolhaExtras = MenuRefeicao.GetCheckedItems<Extra>(extras);
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
                            cliente.Saldo -= Menu.precoEstudante + sumPrecoExtra + multa.Valor;

                            db.Reservas.Add(new Reserva(cliente, multa, Menu, escolhaExtras, prato));

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
                            cliente.Saldo -= Menu.precoEstudante + sumPrecoExtra;

                            db.Reservas.Add(new Reserva(cliente, Menu, escolhaExtras, prato));

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
                            cliente.Saldo -= Menu.precoProfessor + sumPrecoExtra + multa.Valor;

                            db.Reservas.Add(new Reserva(cliente, multa, Menu, escolhaExtras, prato));

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
                            cliente.Saldo -= Menu.precoProfessor + sumPrecoExtra;

                            db.Reservas.Add(new Reserva(cliente, Menu, escolhaExtras, prato));

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
            db.Reservas.Remove(reservaEscolhida);
            db.SaveChanges();
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
            List<Reserva> listaReservas = db.Reservas
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

