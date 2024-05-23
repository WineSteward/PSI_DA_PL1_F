using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PSI_DA_PL1_F.Views
{
    public partial class FormMenuPrincipal : System.Windows.Forms.Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // está hide porque assim n fecha o programa e acho que é melhor assim quando se for abrir outros forms
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // test 1

            // show FormLogin in panel 2
            PSI_DA_PL1_F.Views.Form login = new PSI_DA_PL1_F.Views.Form();
            login.TopLevel = false;
            if (panel2.Controls.Count > 0)
                panel2.Controls.Clear();
            panel2.Controls.Add(login);
            login.BringToFront();
            login.Show();

            /*this.Close();

            PSI_DA_PL1_F.Views.FormLogin formlogin = new PSI_DA_PL1_F.Views.FormLogin(); // ver se isto está a dar
            formlogin.Show();*/
        }
    }
}
