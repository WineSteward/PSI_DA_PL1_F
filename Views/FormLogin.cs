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
    public partial class Form : System.Windows.Forms.Form
    {
        private ControllerFuncionario controladorFuncionario;
        public Form()
        {
            InitializeComponent();

            this.controladorFuncionario = new ControllerFuncionario();
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

            this.controladorFuncionario.RegistarFuncionario(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // apagar funcionario

            // não esta a funcionar
            using (var db = new CantinaContext())
            {
                var funcionario = db.Funcionarios.Find(dataGridView1.SelectedCells);
                db.Funcionarios.Remove(funcionario);
                db.SaveChanges();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (var db = new CantinaContext())
            {
                var funcionario = db.Funcionarios.ToList();
                dataGridView1.DataSource = funcionario;
            }
        }
    }
}