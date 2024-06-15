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
        MenuRefeicao menu;
        public FormReserva(FormMenuPrincipal menuPrincipal, MenuRefeicao Menu)
        {
            InitializeComponent();

            this.menuPrincipal = menuPrincipal;
            this.menu = Menu;

            this.TopLevel = false;
            this.AutoScroll = true;

            menuPrincipal.panelShowForm.Controls.Add(this);

            this.Show();

            controladorReserva = new ControllerReserva(menuPrincipal.db, menu);

            listBoxClientes.DataSource = controladorReserva.UpdateListBoxClientes();
            listBoxReservas.DataSource = controladorReserva.UpdateListBoxReservas(menu);
            checkedListBoxExtras.DataSource = controladorReserva.UpdateListBoxExtras(menu);
            listBoxPratos.DataSource = controladorReserva.UpdateListBoxPratos(menu);

        }

        private void buttonAdicionarReserva_Click(object sender, EventArgs e)
        {
            controladorReserva.AddReserva((Cliente)listBoxClientes.SelectedItem, (Prato)listBoxPratos.SelectedItem, checkedListBoxExtras);
            listBoxReservas.DataSource = controladorReserva.UpdateListBoxReservas(menu);
        }

        private void btnConsumir_Click(object sender, EventArgs e)
        {
            controladorReserva.ConsumirReserva((Reserva)listBoxReservas.SelectedItem);
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
    }
}
