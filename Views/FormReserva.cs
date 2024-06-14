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

        public FormReserva(FormMenuPrincipal menuPrincipal, MenuRefeicao Menu)
        {
            InitializeComponent();

            this.menuPrincipal = menuPrincipal;
            controladorReserva = new ControllerReserva(menuPrincipal, menuPrincipal.db, Menu);

            listBoxClientes.DataSource = controladorReserva.UpdateListBoxClientes();
            listBoxReservas.DataSource = controladorReserva.UpdateListBoxReservas();
            checkedListBoxExtras.DataSource = controladorReserva.UpdateListBoxExtras();
            listBoxPratos.DataSource = controladorReserva.UpdateListBoxPratos();

        }

        private void buttonAdicionarReserva_Click(object sender, EventArgs e)
        {
            controladorReserva.AddReserva((Cliente)listBoxClientes.SelectedItem, (Prato)listBoxPratos.SelectedItem, checkedListBoxExtras);
        }

        private void btnConsumir_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBoxExtras_Click(object sender, EventArgs e)
        {
            if (checkedListBoxExtras.CheckedItems.Count > 3)
            { 
                checkedListBoxExtras.SetItemCheckState(checkedListBoxExtras.SelectedIndex, CheckState.Unchecked);
            }
        }

      
    }
}
