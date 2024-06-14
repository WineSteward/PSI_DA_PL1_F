using PSI_DA_PL1_F.Models;
using PSI_DA_PL1_F.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ControllerReserva : Controller
    {
        private CantinaContext db;
        private FormMenuPrincipal menuPrincipal;
        private MenuRefeicao Menu;
        List<Prato> listaPratos;
        List<Extra> listaExtras;
        List<Extra> escolhaExtras;
        Multa multa;
       

        public ControllerReserva(FormMenuPrincipal menuPrincipal, CantinaContext db, MenuRefeicao Menu)
        {
            this.db = db;
            this.Menu = Menu;
        }

        public void AddReserva(Cliente cliente, Prato prato, CheckedListBox extras)
        {
            escolhaExtras = Reserva.GetCheckedItems(extras);

            foreach (Extra extra in escolhaExtras)
            {
                escolhaExtras.Add(extra);
            }


            db.Reservas.Add(new Reserva(cliente, multa, Menu, escolhaExtras, prato));
        }


        public List<Cliente> UpdateListBoxClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            listaClientes = db.Estudantes.ToList<Cliente>();

            listaClientes.AddRange(db.Professores.ToList<Cliente>());

            return listaClientes;
        }

        public List<Extra> UpdateListBoxExtras()
        {

            foreach (Extra extra in Menu.Extras)
            {
                listaExtras.Add(extra);
            }

            return listaExtras;
        }

        public List<Reserva> UpdateListBoxReservas()
        {

            //Ir buscar as reservas que tenham a data hora do menu
            db.Reservas.Where(reserva => reserva in Menu.DataHora).ToList();
            
            
            List<Reserva> listaReservas = new List<Reserva>();


            listaReservas = db.Reservas.ToList<Reserva>();

            return listaReservas;
        }

        public List<Prato> UpdateListBoxPratos()
        {
            foreach(Prato prato in Menu.Pratos)
            {
                listaPratos.Add(prato);
            }

            return listaPratos;
        }
    }
}

