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
    public partial class FormExtras : Form
    {
        private ControllerExtras controladorExtras;
        public FormExtras(FormMenuPrincipal menuPrincipal)
        {
            InitializeComponent();

            controladorExtras = new ControllerExtras(menuPrincipal, menuPrincipal.db);

            listBoxExtras.DataSource = controladorExtras.UpdateListBox();
        }

        private void btnAdicionarExtra_Click(object sender, EventArgs e)
        {
            controladorExtras.AddExtra(textBoxDescricao.Text, numericUpDownPreco.Value, checkBoxAtivarEdit.Checked);

            listBoxExtras.DataSource = controladorExtras.UpdateListBox();
        }
        private void btnUpdateExtra_Click(object sender, EventArgs e)
        {
            controladorExtras.UpdateExtra(textBoxDescricaoEdit.Text, numericUpDownPrecoEdit.Value, checkBoxAtivarEdit.Checked, (Extra)listBoxExtras.SelectedItem);
            listBoxExtras.DataSource = controladorExtras.UpdateListBox();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            controladorExtras.CloseForm();
        }

        private void btnRemoverExtra_Click(object sender, EventArgs e)
        {
            controladorExtras.RemoveExtra(listBoxExtras.SelectedItem);
            listBoxExtras.DataSource = controladorExtras.UpdateListBox();
        }

        private void listBoxExtras_SelectedIndexChanged(object sender, EventArgs e)
        {
            Extra extraAtual = controladorExtras.FindExtra((Extra)listBoxExtras.SelectedItem);

            textBoxDescricaoEdit.Text = extraAtual.Descricao;
            numericUpDownPrecoEdit.Value = extraAtual.Valor;
            checkBoxAtivarEdit.Checked = extraAtual.Ativo;
        }
    }
}
