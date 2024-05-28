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
    public partial class FormLogin : Form
    {
        private ControllerFuncionario controladorFuncionario;
        private CantinaContext db;
        public FormLogin(CantinaContext db)
        {
            InitializeComponent();

            this.db = db;
            this.controladorFuncionario = new ControllerFuncionario();
            if (db.Funcionarios != null)
                listBoxFuncionarios.DataSource = db.Funcionarios;

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void btnDirecionarRegisto_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            this.controladorFuncionario.RegistarFuncionario(textBox1.Text, textBox2.Text, textBox3.Text, this.db);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // apagar funcionario

            // não esta a funcionar
            using (var db = new CantinaContext())
            {
                var funcionario = db.Funcionarios.Find(listBoxFuncionarios.SelectedIndex);
                db.Funcionarios.Remove(funcionario);
                db.SaveChanges();
            }
        }
    }
}