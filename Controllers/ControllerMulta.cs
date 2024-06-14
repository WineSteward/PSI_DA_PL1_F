using PSI_DA_PL1_F.Models;
using PSI_DA_PL1_F.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ControllerMulta
    {
        CantinaContext db;
        FormMenuPrincipal menuPrincipal;

        public ControllerMulta(FormMenuPrincipal menuPrincipal, CantinaContext db)
        {
            this.db = db;
            this.menuPrincipal = menuPrincipal;
        }

        public void AddMulta(decimal numeroHoras, decimal valor)
        {
            db.Multas.Add(new Multa(numeroHoras, valor));
            db.SaveChanges();
        }

        public void CloseForm()
        {
            menuPrincipal.panelShowForm.Controls.Clear();

            menuPrincipal.sidebar.Enabled = true;
        }

        public List<Multa> UpdateListBox()
        {
            List<Multa> listaMulta = new List<Multa>();

            listaMulta = db.Multas.ToList<Multa>();

            return listaMulta;
        }

        public void RemoveMulta(object multaAtual)
        {
            if (multaAtual is Multa)
                db.Multas.Remove((Multa)multaAtual);

            db.SaveChanges();
        }

        public Multa FindMulta(Multa multaAtual)
        {
            return db.Multas.Find(multaAtual.Id);
        }

        public void UpdateMulta(decimal numeroHoras, decimal valor, Multa multaAtual)
        {
            multaAtual = db.Multas.Find(multaAtual.Id);

            multaAtual.NumeroHoras = numeroHoras;
            multaAtual.Valor = valor;

            db.SaveChanges();
        }
    }
}
