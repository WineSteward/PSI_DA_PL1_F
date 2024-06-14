using PSI_DA_PL1_F.Models;
using PSI_DA_PL1_F.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ControllerExtras
    {
            CantinaContext db;
            FormMenuPrincipal menuPrincipal;

            public ControllerExtras(FormMenuPrincipal menuPrincipal, CantinaContext db)
            {
                this.db = db;
                this.menuPrincipal = menuPrincipal;
            }

            public void AddExtra(string descricao, decimal saldo, bool estado)
            {
                db.Extras.Add(new Extra(descricao, saldo, estado));
                db.SaveChanges();
            }

            public void CloseForm()
            {
                menuPrincipal.panelShowForm.Controls.Clear();

                menuPrincipal.sidebar.Enabled = true;
            }

            public List<Extra> UpdateListBox()
            {
                List<Extra> listaExtras = new List<Extra>();

                listaExtras = db.Extras.ToList<Extra>();

                return listaExtras;
            }

            public void RemoveExtra(object extraAtual)
            {
                if (extraAtual is Extra)
                    db.Extras.Remove((Extra)extraAtual);

                db.SaveChanges();
            }

            public Extra FindExtra(Extra extraAtual)
            {
               return db.Extras.Find(extraAtual.Id);
            }

            public void UpdateExtra(string descricao, decimal valor, bool ativo, Extra extraAtual)
            {
                extraAtual = db.Extras.Find(extraAtual.Id);

                extraAtual.Descricao = descricao;
                extraAtual.Valor = valor;
                extraAtual.Ativo = ativo;

                db.SaveChanges();
            }
    }
}

