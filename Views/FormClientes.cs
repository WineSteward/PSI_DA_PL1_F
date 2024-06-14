using PSI_DA_PL1_F.Controllers;
using PSI_DA_PL1_F.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Views
{
    public partial class FormClientes : Form
    {
        FormMenuPrincipal menuPrincipal;
        ControllerCliente controladorCliente;
        public FormClientes(FormMenuPrincipal menuPrincipal)
        {
            InitializeComponent();

            this.menuPrincipal = menuPrincipal;

            controladorCliente = new ControllerCliente(menuPrincipal, menuPrincipal.db);

            listBoxTipoCliente.Items.Add("Estudante");
            listBoxTipoCliente.Items.Add("Professor");
            listBoxTipoClienteEdit.Items.Add("Estudante");
            listBoxTipoClienteEdit.Items.Add("Professor");

            listBoxClientes.DataSource = controladorCliente.UpdateListBox();

        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            if(listBoxTipoCliente.SelectedItem.ToString() == "Estudante")
                controladorCliente.AddEstudante(textBoxNome.Text, textBoxNIF.Text, numericUpDownSaldo.Value, textBoxNumEstudante.Text);
            
            else
                controladorCliente.AddProfessor(textBoxNome.Text, textBoxNIF.Text, numericUpDownSaldo.Value, textBoxEmailProfessor.Text);

            listBoxClientes.DataSource = controladorCliente.UpdateListBox();

            textBoxNomeEdit.Text = "";
            textBoxNIFEdit.Text = "";
            numericUpDownSaldoEdit.Value = 0;

            textBoxNumEstudanteEdit.Text = "";
            textBoxEmailProfessorEdit.Text = "";


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            menuPrincipal.panelShowForm.Controls.Clear();

            menuPrincipal.sidebar.Enabled = true;
        }

        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {
            controladorCliente.RemoveCliente(listBoxClientes.SelectedItem);
            listBoxClientes.DataSource = controladorCliente.UpdateListBox();
        }

        private void btnUpdateCliente_Click(object sender, EventArgs e)
        {
            if (listBoxTipoClienteEdit.SelectedItem.ToString() == "Estudante")
                controladorCliente.UpdateEstudante(textBoxNomeEdit.Text, textBoxNIFEdit.Text, numericUpDownSaldoEdit.Value, textBoxNumEstudanteEdit.Text, (Cliente)listBoxClientes.SelectedItem);

            else
                controladorCliente.UpdateProfessor(textBoxNomeEdit.Text, textBoxNIFEdit.Text, numericUpDownSaldoEdit.Value, textBoxEmailProfessorEdit.Text, (Cliente)listBoxClientes.SelectedItem);

            listBoxClientes.DataSource = controladorCliente.UpdateListBox();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteAtual = controladorCliente.FindCliente((Cliente)listBoxClientes.SelectedItem);
               
            textBoxNomeEdit.Text = clienteAtual.Nome;
            textBoxNIFEdit.Text =clienteAtual.NIF;
            numericUpDownSaldoEdit.Value = clienteAtual.Saldo;

            if (clienteAtual is Estudante)
            {
                Estudante estudanteAtual = clienteAtual as Estudante;
                listBoxTipoClienteEdit.SetSelected(0, true);
                textBoxNumEstudanteEdit.Text = estudanteAtual.NumeroEstudante;
            }
            else
            {
                Professor professorAtual = clienteAtual as Professor;
                listBoxTipoClienteEdit.SetSelected(1, true);
                textBoxEmailProfessorEdit.Text = professorAtual.EmailProfessor;
            }
        }
    }
}
