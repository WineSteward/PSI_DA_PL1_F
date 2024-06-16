using PSI_DA_PL1_F.Controllers;
using System;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Views
{
    public partial class FormMenuPrincipal : Form
    {
        public CantinaContext db;

        bool menuExpand = false;

        ControllerMenuPrincipal controladorMenuPrincipal;

        public FormMenuPrincipal()
        {
            InitializeComponent();

            this.FormClosed += Form_Closed;

            this.db = new CantinaContext();
           
            controladorMenuPrincipal = new ControllerMenuPrincipal(this);

            controladorMenuPrincipal.ShowFormFuncionario();

        }
       
      
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelShowForm.Controls.Clear();

            sidebar.Enabled = false;

            controladorMenuPrincipal.ShowFormFuncionario();
        }

      
        private void btnFormClientes(object sender, EventArgs e)
        {
            controladorMenuPrincipal.ShowFormCliente();
        }


        private void btnFormExtras_Click(object sender, EventArgs e)
        {
            controladorMenuPrincipal.ShowFormExtras();
        }

        private void btnFormMulta_Click(object sender, EventArgs e)
        {
            controladorMenuPrincipal.ShowFormMultas();
        }

        private void btnFormPratos_Click(object sender, EventArgs e)
        {
            controladorMenuPrincipal.ShowFormPratos();
        }

        private void btnVistaSemanal_Click(object sender, EventArgs e)
        {
            controladorMenuPrincipal.ShowFormVistaSemanal();
        }

        private void btnMenuRefeicao_Click(object sender, EventArgs e)
        {
            controladorMenuPrincipal.ShowVistaMenuRefeicao();
        }

        //-----------------------------------------------Animation-----------------------------------------------------

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                estudanteMenu.Height += 10;
                if (estudanteMenu.Height >= 160)
                {
                    clienteTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                estudanteMenu.Height -= 10;
                if (estudanteMenu.Height <= 90)
                {
                    clienteTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void Cliente_Click(object sender, EventArgs e)
        {
            clienteTransition.Start();
        }
        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 40)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 237)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            settingsTransition.Start();
        }

        private void settingsTransition_Click(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuOpcoes.Height += 10;
                if (menuOpcoes.Height >= 415)
                {
                    settingsTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuOpcoes.Height -= 10;
                if (menuOpcoes.Height <= 90)
                {
                    settingsTransition.Stop();
                    menuExpand = false;
                }
            }
        }

       
    }
}
