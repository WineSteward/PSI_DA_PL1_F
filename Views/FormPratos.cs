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
        private FormMenuPrincipal menuPrincipal;

        public FormPratos(FormMenuPrincipal menuPrincipal)
        {
            InitializeComponent();

            this.menuPrincipal = menuPrincipal;

            controladorPratos = new ControllerPratos(menuPrincipal.db);

            //Atualizar as listbox por default
            listBoxTipoPratoEdit.DataSource = controladorPratos.UpdateListBoxTipo();

            listBoxPratos.DataSource = controladorPratos.UpdateListBoxPratos();

            listBoxTipoPrato.DataSource = controladorPratos.UpdateListBoxTipo();
        }


        //Adicoinar prato a lista de pratos disponiveis
        private void btnAdicionarPrato_Click(object sender, EventArgs e)
        {
            controladorPratos.AddPrato(textBoxDescricao.Text, (TipoPrato)listBoxTipoPrato.SelectedItem, checkBoxAtivarPrato.Checked);

            textBoxDescricao.Clear();
            checkBoxAtivarPrato.Checked = false;


            listBoxPratos.DataSource = controladorPratos.UpdateListBoxPratos();
        }

        //atualizar os dados do prato selecionado na listbox
        private void btnUpdatePrato_Click(object sender, EventArgs e)
        {
            controladorPratos.UpdatePrato(textBoxDescricaoEdit.Text, checkBoxAtivarPratoEdit.Checked, (Prato)listBoxPratos.SelectedItem);
            listBoxPratos.DataSource = controladorPratos.UpdateListBoxPratos();
        }

        //Preencher por default os dados dos prato selecionado na zona de edicao
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

        //remover o prato da base de dados
        private void btnRemoverPrato_Click(object sender, EventArgs e)
        {
            controladorPratos.RemovePrato(listBoxPratos.SelectedItem);
            listBoxPratos.DataSource = controladorPratos.UpdateListBoxPratos();
        }

        //return ao menu principal
        private void btnReturn_Click(object sender, EventArgs e)
        {
            menuPrincipal.panelShowForm.Controls.Clear();

            menuPrincipal.sidebar.Enabled = true;
        }
    }
}
