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

            controladorCliente = new ControllerCliente(menuPrincipal.db);


            //Preencher as listboxs por default
            listBoxTipoCliente.Items.Add("Estudante");
            listBoxTipoCliente.Items.Add("Professor");
            listBoxTipoClienteEdit.Items.Add("Estudante");
            listBoxTipoClienteEdit.Items.Add("Professor");
            listBoxTipoClienteSearch.Items.Add("Estudante");
            listBoxTipoClienteSearch.Items.Add("Professor");

            listBoxClientes.DataSource = controladorCliente.UpdateListBox();

        }

        //Adicionar cliente a base de dados
        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            //front end validations
            if (listBoxTipoCliente.SelectedItem.ToString() == "Estudante" && textBoxNome.Text != "" && textBoxNIF.Text != "" && textBoxNumEstudante.Text != "")
                if (Utilizador.ValidarNif(textBoxNIF.Text))
                {
                    MessageBox.Show("Formato do NIF inválido");
                    return;
                }
                else
                    controladorCliente.AddEstudante(textBoxNome.Text, textBoxNIF.Text, numericUpDownSaldo.Value, textBoxNumEstudante.Text);

            else if (listBoxTipoCliente.SelectedItem.ToString() == "Professor" && textBoxNome.Text != "" && textBoxNIF.Text != "" && textBoxEmailProfessor.Text != "")
            {
                if (Professor.IsValidEmail(textBoxEmailProfessor.Text))
                    if (Utilizador.ValidarNif(textBoxNIF.Text))
                        controladorCliente.AddProfessor(textBoxNome.Text, textBoxNIF.Text, numericUpDownSaldo.Value, textBoxEmailProfessor.Text);
                    else
                    {
                        MessageBox.Show("NIF inválido");
                        return;
                    }
                else
                {
                    MessageBox.Show("Email inválido");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os parametros necessários");
                return;
            }

            listBoxClientes.DataSource = controladorCliente.UpdateListBox();

            textBoxNome.Text = "";
            textBoxNIF.Text = "";
            numericUpDownSaldo.Value = 0;

            textBoxNumEstudante.Text = "";
            textBoxEmailProfessor.Text = "";


        }

        //return para o menu principal
        private void btnReturn_Click(object sender, EventArgs e)
        {
            menuPrincipal.panelShowForm.Controls.Clear();

            menuPrincipal.sidebar.Enabled = true;
        }

        //Remover cliente da base de dados
        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {
            controladorCliente.RemoveCliente(listBoxClientes.SelectedItem);
            listBoxClientes.DataSource = controladorCliente.UpdateListBox();
        }

        //Atualizar os dados do cliente na base de dados
        private void btnUpdateCliente_Click(object sender, EventArgs e)
        {
            if (listBoxTipoClienteEdit.SelectedItem.ToString() == "Estudante" && textBoxNomeEdit.Text != "" && textBoxNIFEdit.Text != "" && textBoxNumEstudanteEdit.Text != "")
                if (Utilizador.ValidarNif(textBoxNIFEdit.Text))
                {
                    MessageBox.Show("Formato do NIF inválido");
                    return;
                }
                else
                    controladorCliente.UpdateEstudante(textBoxNomeEdit.Text, textBoxNIFEdit.Text, numericUpDownSaldoEdit.Value, textBoxNumEstudanteEdit.Text, (Cliente)listBoxClientes.SelectedItem);

            else if (listBoxTipoClienteEdit.SelectedItem.ToString() == "Professor" && textBoxNomeEdit.Text != "" && textBoxNIFEdit.Text != "" && textBoxEmailProfessorEdit.Text != "")
                if (Professor.IsValidEmail(textBoxEmailProfessorEdit.Text) && Utilizador.ValidarNif(textBoxNIFEdit.Text))
                    controladorCliente.AddProfessor(textBoxNomeEdit.Text, textBoxNIFEdit.Text, numericUpDownSaldoEdit.Value, textBoxEmailProfessorEdit.Text);

                else
                {
                    MessageBox.Show("Endereço de email inválido");
                    return;
                }

            else
            {
                MessageBox.Show("Preencha todos os parametros necessários");
                return;
            }

            listBoxClientes.DataSource = controladorCliente.UpdateListBox();
        }

        //Preencher a zona de edicao do cliente com os dados do cliente selecionado
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxEmailProfessorEdit.Text = "";

            textBoxNumEstudanteEdit.Text = "";

            Cliente clienteAtual = controladorCliente.FindCliente((Cliente)listBoxClientes.SelectedItem);

            textBoxNomeEdit.Text = clienteAtual.Nome;
            textBoxNIFEdit.Text = clienteAtual.NIF;
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

        //Procurar pelo cliente pelo nome e/ou tipo
        private void btnSearchCliente_Click(object sender, EventArgs e)
        {
            //Front end validations
            if (textBoxNomeSearch.Text == "")
                listBoxClientes.DataSource = controladorCliente.FindCliente(listBoxTipoClienteSearch);

            else if (listBoxTipoClienteSearch.SelectedItem == null && textBoxNomeSearch.Text != "")
                listBoxClientes.DataSource = controladorCliente.FindCliente(textBoxNomeSearch.Text);

            else if (listBoxTipoClienteSearch.SelectedItem != null && textBoxNomeSearch.Text != "")
                listBoxClientes.DataSource = controladorCliente.FindCliente(textBoxNomeSearch.Text, listBoxTipoClienteSearch);

            else
            {
                MessageBox.Show("Parametros inválidos");
                return;
            }

            textBoxNomeSearch.Text = "";
            listBoxTipoClienteSearch.ClearSelected();
        }

        //Atualizar a listbox dos clientes on demand
        private void btnUpdateListBoxClientes_Click(object sender, EventArgs e)
        {
            listBoxClientes.DataSource = controladorCliente.UpdateListBox();
        }

        //Mudar o tipo de cliente possibilita e elimina certos campos
        private void listBoxTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTipoCliente.SelectedItem.ToString() == "Estudante")
            {
                textBoxNumEstudante.Enabled = true;
                textBoxEmailProfessor.Enabled = false;
            }
            else
            {
                textBoxNumEstudante.Enabled = false;
                textBoxEmailProfessor.Enabled = true;
            }
        }

        private void listBoxTipoClienteEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTipoClienteEdit.SelectedItem.ToString() == "Estudante")
            {
                textBoxNumEstudanteEdit.Enabled = true;
                textBoxEmailProfessorEdit.Enabled = false;
            }
            else
            {
                textBoxNumEstudanteEdit.Enabled = false;
                textBoxEmailProfessorEdit.Enabled = true;
            }
        }
    }
}
