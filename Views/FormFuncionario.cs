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
        public FormFuncionario(CantinaContext db, FormMenuPrincipal mainForm)
        {
            InitializeComponent();

            this.db = db;
            this.mainForm = mainForm;
            this.controladorFuncionario = new ControllerFuncionario();
            if (db.Funcionarios != null)
                listBoxFuncionarios.DataSource = db.Funcionarios;

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (listBoxFuncionarios.SelectedItem == null)
                return;

            Funcionario funcionarioAtual = (Funcionario)listBoxFuncionarios.SelectedItem;

            //passar o funcionarioAtual(desnecessario segundo o enunciado)
            //para o main form


            //uso o form que recebi e mudo o estado da sidebar e fecho este form
            mainForm.sidebar.Enabled = true;
            this.Close();
            

        }

        private void btnDirecionarRegisto_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            this.controladorFuncionario.RegistarFuncionario(textBox1.Text, textBox2.Text, textBox3.Text, db);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Funcionario funcionarioAtual = (Funcionario)listBoxFuncionarios.SelectedItem;
            this.controladorFuncionario.RemoveFuncionario(db, funcionarioAtual);
        }
    }
}