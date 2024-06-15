using PSI_DA_PL1_F.Models;
using PSI_DA_PL1_F.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void AddReserva(Cliente cliente, Prato prato, CheckedListBox extras)
        {
            escolhaExtras = Extra.GetCheckedItems(extras);
            
            db.Reservas.Add(new Reserva(cliente, multa, Menu, escolhaExtras, prato));
        }

        public void ConsumirReserva(Reserva reservaEscolhida)
        {
            db.Reservas.Remove(reservaEscolhida);
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

            foreach (Extra extra in Menu.Extras)
            {
                listaExtras.Add(extra);
            }

            return listaExtras;
        }

        public List<Reserva> UpdateListBoxReservas(MenuRefeicao Menu)
        {
            List<Reserva> listaReservas = db.Reservas
                                     .Where(r => r.Menu.Id == Menu.Id)
                                     .ToList();

            return listaReservas;
        }

        public List<Prato> UpdateListBoxPratos(MenuRefeicao menu)
        {
            foreach(Prato prato in menu.Pratos)
            {
                listaPratos.Add(prato);
            }

            return listaPratos;
        }
    }
}

