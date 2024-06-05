using PSI_DA_PL1_F.Controllers;
using System;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Views
{
    public partial class FormMenuPrincipal : Form
    {
        public CantinaContext db;

        ControllerMenuPrincipal controladorMenuPrincipal;
        ControllerMenuRefeicao controladorMenuRefeicao;
        ControllerExtras controladorExtras;
        ControllerMulta controladorMulta;
        ControllerPratos controladorPratos;
        ControllerReserva controladorReserva;

        public FormMenuPrincipal()
        {
            InitializeComponent();

            this.FormClosed += Form_Closed;

            this.db = new CantinaContext();
           
            controladorMenuPrincipal = new ControllerMenuPrincipal(this);

        }
        bool menuExpand = false;


        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false)
            {
                estudanteMenu.Height += 10;
                if(estudanteMenu.Height >= 252) 
                {
                    clienteTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                estudanteMenu.Height -= 10;
                if(estudanteMenu.Height <= 90)
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
                if(sidebar.Width <= 42)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else 
            {
                sidebar.Width += 10;
                if(sidebar.Width >= 237)
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
                professorMenu.Height += 10;
                if (professorMenu.Height >= 252)
                {
                    settingsTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                professorMenu.Height -= 10;
                if (professorMenu.Height <= 90)
                {
                    settingsTransition.Stop();
                    menuExpand = false;
                }
            }
        }
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.panelShowForm.Controls.Clear();

            ControllerMenuPrincipal controladorMenuPrincipal = new ControllerMenuPrincipal(this);
        }

      
        private void btnFormClientes(object sender, EventArgs e)
        {

        }

        private void btnReservarRefeicao_Click(object sender, EventArgs e)
        {

        }
    }
}
