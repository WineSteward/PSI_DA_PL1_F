using PSI_DA_PL1_F.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ControllerCliente : Controller
    {
        CantinaContext db;
        FormMenuPrincipal menuPrincipal;
        public ControllerCliente(FormMenuPrincipal menuPrincipal, CantinaContext db) 
        {
            this.db = db;
            this.menuPrincipal = menuPrincipal;

            menuPrincipal.sidebar.Enabled = false;

            FormClientes clienteForm = new FormClientes(menuPrincipal);

            clienteForm.TopLevel = false;
            clienteForm.AutoScroll = true;
            menuPrincipal.panelShowForm.Controls.Add(clienteForm);
            clienteForm.Show();
        }

    }
}
