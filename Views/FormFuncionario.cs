using PSI_DA_PL1_F.Controllers;
using PSI_DA_PL1_F.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PSI_DA_PL1_F.Views
{
    public partial class FormFuncionario : Form
    {
        private ControllerFuncionario controladorFuncionario;
        private CantinaContext db;
        private FormMenuPrincipal mainForm;
        private List<Funcionario> listFuncionario;
        private Funcionario funcionarioAtual;

        public FormFuncionario(FormMenuPrincipal mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.db = mainForm.db;
            this.controladorFuncionario = new ControllerFuncionario();

            listFuncionario = this.controladorFuncionario.UpdateListBoxFuncionario(db);

            listBoxFuncionarios.DataSource = listFuncionario;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (listBoxFuncionarios.SelectedItem == null)
                return;

            funcionarioAtual = (Funcionario)listBoxFuncionarios.SelectedItem;

            //uso o form que recebi e mudo o estado da sidebar e fecho este form
            mainForm.sidebar.Enabled = true;
            this.Close();
            

        }

        private void btnDirecionarRegisto_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxNome.Text == "" || textBoxNIF.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            this.controladorFuncionario.RegistarFuncionario(textBoxUsername.Text, textBoxNome.Text, textBoxNIF.Text, db);

            textBoxUsername.Text = "";
            textBoxNome.Text = "";
            textBoxNIF.Text = "";

            listBoxFuncionarios.DataSource = this.controladorFuncionario.UpdateListBoxFuncionario(db);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            funcionarioAtual = (Funcionario)listBoxFuncionarios.SelectedItem;

            this.controladorFuncionario.RemoveFuncionario(db, funcionarioAtual);
            
            listBoxFuncionarios.DataSource = this.controladorFuncionario.UpdateListBoxFuncionario(db);
        }
    }
}