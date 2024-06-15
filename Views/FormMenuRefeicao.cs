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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PSI_DA_PL1_F.Views
{
    public partial class FormMenuRefeicao : Form
    {
        FormMenuPrincipal menuPrincipal;
        ControllerMenuRefeicao controladorMenuRefeicao;
        public FormMenuRefeicao(FormMenuPrincipal menuPrincipal, DateTime dia)
        {
            InitializeComponent();

            this.menuPrincipal = menuPrincipal;

            this.TopLevel = false;
            this.AutoScroll = true;

            menuPrincipal.sidebar.Enabled = false;

            menuPrincipal.panelShowForm.Controls.Add(this);

            this.Show();

            controladorMenuRefeicao = new ControllerMenuRefeicao(menuPrincipal.db);

            dateTimePicker.Value = dia;

            checkedListBoxPratosEdit.DataSource = controladorMenuRefeicao.UpdateListBoxPratos();
            checkedListBoxExtrasEdit.DataSource = controladorMenuRefeicao.UpdateListBoxExtras();
            checkedListBoxPratos.DataSource = controladorMenuRefeicao.UpdateListBoxPratos();
            checkedListBoxExtras.DataSource = controladorMenuRefeicao.UpdateListBoxExtras();
            listBoxMenuRefeicoes.DataSource = controladorMenuRefeicao.UpdateListBoxMenus();

        }

        public FormMenuRefeicao(FormMenuPrincipal menuPrincipal)
        {
            InitializeComponent();

            this.menuPrincipal = menuPrincipal;

            controladorMenuRefeicao = new ControllerMenuRefeicao(menuPrincipal.db);

            checkedListBoxPratosEdit.DataSource = controladorMenuRefeicao.UpdateListBoxPratos();
            checkedListBoxExtrasEdit.DataSource = controladorMenuRefeicao.UpdateListBoxExtras();
            checkedListBoxPratos.DataSource = controladorMenuRefeicao.UpdateListBoxPratos();
            checkedListBoxExtras.DataSource = controladorMenuRefeicao.UpdateListBoxExtras();
            listBoxMenuRefeicoes.DataSource = controladorMenuRefeicao.UpdateListBoxMenus();

        }


        private void btnAdicionarMenu_Click(object sender, EventArgs e)
        {
            controladorMenuRefeicao.AddMenu(dateTimePicker.Value, numericUpDownQtddDisponivel.Value, numericUpDownPrecoEstudante.Value, numericUpDownPrecoProfessor.Value, checkedListBoxPratos, checkedListBoxExtras);

            listBoxMenuRefeicoes.DataSource = controladorMenuRefeicao.UpdateListBoxMenus();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            menuPrincipal.panelShowForm.Controls.Clear();

            menuPrincipal.sidebar.Enabled = true;
        }

        private void listBoxMenuRefeicoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuRefeicao menuAtual = (MenuRefeicao)listBoxMenuRefeicoes.SelectedItem;

            for (int i = 0; i < checkedListBoxPratosEdit.Items.Count; i++)
            {
                // limpar os checks da checkbox
                checkedListBoxPratosEdit.SetItemChecked(i, false);
            }

            for (int i = 0; i < checkedListBoxExtrasEdit.Items.Count; i++)
            {
                // limpar os checks da checkbox
                checkedListBoxExtrasEdit.SetItemChecked(i, false);
            }



            dateTimePickerEdit.Value = menuAtual.DataHora;

            numericUpDownPrecoEstudanteEdit.Value = menuAtual.precoEstudante;
            numericUpDownPrecoProfessorEdit.Value = menuAtual.precoProfessor;

            numericUpDownQtddDisponivelEdit.Value = menuAtual.Quantidade;

            // Percorrer todos os itens da checkboxlist
            for (int i = 0; i < checkedListBoxPratosEdit.Items.Count; i++)
            {
                Prato prato = (Prato)checkedListBoxPratosEdit.Items[i];

                if (menuAtual.Pratos == null)
                    return;
                
                // Verificar se o prato esta presente na lista de pratos do menuAtual
                if (menuAtual.Pratos.Any(p => p.Id == prato.Id))
                {
                    // Check do prato se estiver presente no menuAtual
                    checkedListBoxPratosEdit.SetItemChecked(i, true);
                }
            }

            // Iterate through each item in the CheckedListBox
            for (int i = 0; i < checkedListBoxExtrasEdit.Items.Count; i++)
            {
                Extra extra = (Extra)checkedListBoxExtrasEdit.Items[i];
                
                if (menuAtual.Extras == null)
                    return;
                
                // Check if this Prato is in the menu.Pratos list
                if (menuAtual.Extras.Any(p => p.Id == extra.Id))
                {
                    // If it is, set the corresponding checkbox to checked
                    checkedListBoxExtrasEdit.SetItemChecked(i, true);
                }
            }
        }

        private void btnAtualizarMenu_Click(object sender, EventArgs e)
        {
            controladorMenuRefeicao.UpdateMenu(dateTimePickerEdit.Value, numericUpDownQtddDisponivelEdit.Value, numericUpDownPrecoEstudanteEdit.Value, numericUpDownPrecoProfessorEdit.Value, checkedListBoxPratosEdit, checkedListBoxExtrasEdit, (MenuRefeicao)listBoxMenuRefeicoes.SelectedItem);
            listBoxMenuRefeicoes.DataSource = controladorMenuRefeicao.UpdateListBoxMenus();
        }
    }
}
