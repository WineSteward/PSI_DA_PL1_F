using PSI_DA_PL1_F.Controllers;
using System;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Views
{
    public partial class FormMenuPrincipal : Form
    {
        public CantinaContext db;
        public FormMenuPrincipal()
        {
            InitializeComponent();

            this.FormClosed += Form_Closed;

            this.db = new CantinaContext();
           
            FormFuncionario funcionarioForm = new FormFuncionario(this);
            funcionarioForm.TopLevel = false;
            funcionarioForm.AutoScroll = true;
            this.panelShowForm.Controls.Add(funcionarioForm);
            funcionarioForm.Show();

        }
        bool menuExpand = false;


        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false)
            {
                estudanteMenu.Height += 10;
                if(estudanteMenu.Height >= 252) 
                {
                    estudanteTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                estudanteMenu.Height -= 10;
                if(estudanteMenu.Height <= 90)
                {
                    estudanteTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void Estudante_Click(object sender, EventArgs e)
        {
            estudanteTransition.Start();
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

        private void Professor_Click(object sender, EventArgs e)
        {
            professorTransition.Start();
        }

        private void professorTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                professorMenu.Height += 10;
                if (professorMenu.Height >= 252)
                {
                    professorTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                professorMenu.Height -= 10;
                if (professorMenu.Height <= 90)
                {
                    professorTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnRefeicaoEstudante_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.panelShowForm.Controls.Clear();
            
            FormFuncionario funcionarioForm = new FormFuncionario(this);
            funcionarioForm.TopLevel = false;
            funcionarioForm.AutoScroll = true;
            this.panelShowForm.Controls.Add(funcionarioForm);
            sidebar.Enabled = false;
            funcionarioForm.Show();
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }

        private void btnFormEstudante_Click(object sender, EventArgs e)
        {

        }
    }
}
