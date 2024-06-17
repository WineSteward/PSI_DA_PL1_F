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
        private FormMenuPrincipal menuPrincipal;
        public FormMulta(FormMenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            controladorMulta = new ControllerMulta(menuPrincipal.db);

            listBoxMultas.DataSource = controladorMulta.UpdateListBox();
        }


        //Adicionar multa a base de dados
        private void btnAdicionarMultas_Click(object sender, EventArgs e)
        {
            controladorMulta.AddMulta(numericUpDownHoras.Value, numericUpDownValor.Value);

            numericUpDownValor.Value = 0;
            numericUpDownHoras.Value = 0;

            listBoxMultas.DataSource = controladorMulta.UpdateListBox();
        }

        //Atualizar os valores da multa ore selecionada
        private void btnUpdateMulta_Click(object sender, EventArgs e)
        {
            controladorMulta.UpdateMulta(numericUpDownHorasEdit.Value, numericUpDownValorEdit.Value, (Multa)listBoxMultas.SelectedItem);
            listBoxMultas.DataSource = controladorMulta.UpdateListBox();
        }

        //atualizar os campos da zona de edicao com os dados da multa selecionada
        private void listBoxMultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Multa multaAtual = controladorMulta.FindMulta((Multa)listBoxMultas.SelectedItem);

            numericUpDownHorasEdit.Value = multaAtual.NumeroHoras;

            numericUpDownValorEdit.Value = multaAtual.Valor;
        }

        //remover a multa da base de dados
        private void btnRemoverMulta_Click(object sender, EventArgs e)
        {
            controladorMulta.RemoveMulta(listBoxMultas.SelectedItem);
            listBoxMultas.DataSource = controladorMulta.UpdateListBox();
        }

        //return ao menu principal
        private void btnReturn_Click(object sender, EventArgs e)
        {
            menuPrincipal.panelShowForm.Controls.Clear();

            menuPrincipal.sidebar.Enabled = true;
        }
    }
}
