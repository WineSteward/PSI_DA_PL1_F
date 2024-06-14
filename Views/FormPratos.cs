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
    public partial class FormPratos : Form
    {
        private ControllerPratos controladorPratos;

        public FormPratos(FormMenuPrincipal menuPrincipal)
        {
            InitializeComponent();

            controladorPratos = new ControllerPratos(menuPrincipal, menuPrincipal.db);

            listBoxTipoPratoEdit.DataSource = controladorPratos.UpdateListBoxTipo();

            listBoxPratos.DataSource = controladorPratos.UpdateListBoxPratos();

            listBoxTipoPrato.DataSource = controladorPratos.UpdateListBoxTipo();

            
        }

        private void btnAdicionarPrato_Click(object sender, EventArgs e)
        {
            controladorPratos.AddPrato(textBoxDescricao.Text, (TipoPrato)listBoxTipoPrato.SelectedItem, checkBoxAtivarPrato.Checked);

            listBoxPratos.DataSource = controladorPratos.UpdateListBoxPratos();
        }

        private void btnUpdatePrato_Click(object sender, EventArgs e)
        {
            controladorPratos.UpdatePrato(textBoxDescricaoEdit.Text, checkBoxAtivarPratoEdit.Checked, (Prato)listBoxPratos.SelectedItem);
            listBoxPratos.DataSource = controladorPratos.UpdateListBoxPratos();
        }

        private void listBoxPratos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prato pratoAtual = controladorPratos.FindPrato((Prato)listBoxPratos.SelectedItem);

            textBoxDescricaoEdit.Text = pratoAtual.Descricao;

            checkBoxAtivarPratoEdit.Checked = pratoAtual.Ativo;

            if (pratoAtual.Tipo == TipoPrato.Carne)
                listBoxTipoPratoEdit.SetSelected(0, true);

            else if (pratoAtual.Tipo == TipoPrato.Peixe)
                listBoxTipoPratoEdit.SetSelected(1, true);

            else
                listBoxTipoPratoEdit.SetSelected(2, true);
            
        }

        private void btnRemoverPrato_Click(object sender, EventArgs e)
        {
            controladorPratos.RemovePrato(listBoxPratos.SelectedItem);
            listBoxPratos.DataSource = controladorPratos.UpdateListBoxPratos();
        }
    }
}
