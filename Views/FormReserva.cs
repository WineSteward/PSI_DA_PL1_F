using PSI_DA_PL1_F.Controllers;
using PSI_DA_PL1_F.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Views
{
    public partial class FormReserva : Form
    {
        private ControllerReserva controladorReserva;
        FormMenuPrincipal menuPrincipal;
        MenuRefeicao menuRefeicao;
        public FormReserva(FormMenuPrincipal menuPrincipal, MenuRefeicao Menu)
        {
            InitializeComponent();

            this.menuPrincipal = menuPrincipal;
            this.menuRefeicao = Menu;

            this.TopLevel = false;
            this.AutoScroll = true;

            menuPrincipal.panelShowForm.Controls.Add(this);

            this.Show();

            controladorReserva = new ControllerReserva(menuPrincipal.db, menuRefeicao);

            listBoxClientes.DataSource = controladorReserva.UpdateListBoxClientes();
            listBoxReservas.DataSource = controladorReserva.UpdateListBoxReservas(menuRefeicao);
            listBoxPratos.DataSource = controladorReserva.UpdateListBoxPratos(menuRefeicao);
            checkedListBoxExtras.DataSource = controladorReserva.UpdateListBoxExtras(menuRefeicao);
            

        }

        private void buttonAdicionarReserva_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem == null || listBoxPratos.SelectedItem == null)
            {
                MessageBox.Show("Escolha de Cliente ou de Prato inválida");
                return;
            }

            int reservaEfetuada = controladorReserva.AddReserva((Cliente)listBoxClientes.SelectedItem, (Prato)listBoxPratos.SelectedItem, checkedListBoxExtras, listBoxReservas);

            if (reservaEfetuada == 1)
            {
                listBoxReservas.DataSource = controladorReserva.UpdateListBoxReservas(menuRefeicao);
                MessageBox.Show("Reserva efetuada com sucesso!");
            }
            else if (reservaEfetuada == 2)
                MessageBox.Show("Cliente tem saldo insuficiente para aquisição de reserva");
            else if (reservaEfetuada == 3)
                MessageBox.Show("Não é possivel efetuar reserva para depois da hora do menu");
            else if (reservaEfetuada == 4)
                MessageBox.Show("Limite de extras ultrapassado, escoha no máximo 3 extras");
            else if (reservaEfetuada == -1)
                MessageBox.Show("Cliente já tem uma reserva para o dia/menu selecionado");
            else
                MessageBox.Show("Limite de reservas excedido para este dia");

            for (int i = 0; i < checkedListBoxExtras.Items.Count; i++)
            {
                // limpar os checks da checkbox
                checkedListBoxExtras.SetItemChecked(i, false);
            }

            Cliente clienteAtual = (Cliente)listBoxClientes.SelectedItem;
            numericUpDownSaldoAtual.Value = clienteAtual.Saldo;
        }

        private void btnAddSaldo_Click(object sender, EventArgs e)
        {
            controladorReserva.AddSaldo((Cliente)listBoxClientes.SelectedItem, numericUpDownSaldoAdd.Value);

            numericUpDownSaldoAdd.Value = 0;
            Cliente clienteAtual = (Cliente)listBoxClientes.SelectedItem;
            numericUpDownSaldoAtual.Value = clienteAtual.Saldo;
        }

        private void btnConsumir_Click(object sender, EventArgs e)
        {
            controladorReserva.ConsumirReserva((Reserva)listBoxReservas.SelectedItem);

            //apos consumir a reserva criar uma fatura com itens do menu (total, e gravar em pdf)


            listBoxReservas.DataSource = controladorReserva.UpdateListBoxReservas(menuRefeicao);
        }

        private void checkedListBoxExtras_Click(object sender, EventArgs e)
        {
            if (checkedListBoxExtras.CheckedItems.Count > 3)
            { 
                checkedListBoxExtras.SetItemCheckState(checkedListBoxExtras.SelectedIndex, CheckState.Unchecked);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            menuPrincipal.panelShowForm.Controls.Clear();

            menuPrincipal.sidebar.Enabled = true;
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteAtual = (Cliente) listBoxClientes.SelectedItem;
            numericUpDownSaldoAtual.Value =  clienteAtual.Saldo;
        }
    }
}
