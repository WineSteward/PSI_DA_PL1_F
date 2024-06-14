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
    public partial class FormMulta : Form
    {
        private ControllerMulta controladorMulta;
        public FormMulta(FormMenuPrincipal menuPrincipal)
        {
            InitializeComponent();

            controladorMulta = new ControllerMulta(menuPrincipal, menuPrincipal.db);

            listBoxMultas.DataSource = controladorMulta.UpdateListBox();
        }

        private void btnAdicionarMultas_Click(object sender, EventArgs e)
        {
            controladorMulta.AddMulta(numericUpDownHoras.Value, numericUpDownValor.Value);

            numericUpDownValor.Value = 0;
            numericUpDownHoras.Value = 0;

            listBoxMultas.DataSource = controladorMulta.UpdateListBox();
        }

        private void btnUpdateMulta_Click(object sender, EventArgs e)
        {
            controladorMulta.UpdateMulta(numericUpDownHorasEdit.Value, numericUpDownValorEdit.Value, (Multa)listBoxMultas.SelectedItem);
            listBoxMultas.DataSource = controladorMulta.UpdateListBox();
        }

        private void listBoxMultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Multa multaAtual = controladorMulta.FindMulta((Multa)listBoxMultas.SelectedItem);

            numericUpDownHorasEdit.Value = multaAtual.NumeroHoras;

            numericUpDownValorEdit.Value = multaAtual.Valor;
        }

        private void btnRemoverMulta_Click(object sender, EventArgs e)
        {
            controladorMulta.RemoveMulta(listBoxMultas.SelectedItem);
            listBoxMultas.DataSource = controladorMulta.UpdateListBox();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            controladorMulta.CloseForm();
        }
    }
}
