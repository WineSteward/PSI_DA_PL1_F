using Microsoft.VisualBasic.ApplicationServices;
using PSI_DA_PL1_F.Models;
using PSI_DA_PL1_F.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Controllers
{
     

    internal class ControllerMenuPrincipal : Controller
    {
        private FormFuncionario funcionarioForm;

        public ControllerMenuPrincipal(Funcionario funcionario)
        {
            
        }

        public ControllerMenuPrincipal(FormMenuPrincipal formMenuPrincipal)
        {
            formMenuPrincipal.sidebar.Enabled = false;
            funcionarioForm = new FormFuncionario(formMenuPrincipal);
            funcionarioForm.TopLevel = false;
            funcionarioForm.AutoScroll = true;
            formMenuPrincipal.panelShowForm.Controls.Add(funcionarioForm);
            funcionarioForm.Show();
        }
    }
}
