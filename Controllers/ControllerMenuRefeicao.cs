using PSI_DA_PL1_F.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ControllerMenuRefeicao
    {
        CantinaContext db;
        FormMenuPrincipal menuPrincipal;
        public ControllerMenuRefeicao(FormMenuPrincipal menuPrincipal, CantinaContext db)
        {
            this.db = db;
            this.menuPrincipal = menuPrincipal;

            menuPrincipal.sidebar.Enabled = false;

            FormMenuRefeicao menuRefeicaoForm = new FormMenuRefeicao(menuPrincipal);

            menuRefeicaoForm.TopLevel = false;
            menuRefeicaoForm.AutoScroll = true;

            menuPrincipal.panelShowForm.Controls.Add(menuRefeicaoForm);

            menuRefeicaoForm.Show();
        }
    }
}
