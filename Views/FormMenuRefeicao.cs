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

        //contrutor se vier do form vista semanal
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

            //atualizar por default todas as listboxes e checkboxes
            checkedListBoxPratosEdit.DataSource = controladorMenuRefeicao.UpdateListBoxPratos();
            checkedListBoxExtrasEdit.DataSource = controladorMenuRefeicao.UpdateListBoxExtras();
            checkedListBoxPratos.DataSource = controladorMenuRefeicao.UpdateListBoxPratos();
            checkedListBoxExtras.DataSource = controladorMenuRefeicao.UpdateListBoxExtras();
            listBoxMenuRefeicoes.DataSource = controladorMenuRefeicao.UpdateListBoxMenus();

        }

        //construtor para se vier do menu principal
        public FormMenuRefeicao(FormMenuPrincipal menuPrincipal)
        {
            InitializeComponent();

            this.menuPrincipal = menuPrincipal;

            controladorMenuRefeicao = new ControllerMenuRefeicao(menuPrincipal.db);

            //atualizar por default todas as listboxes e checkboxes
            checkedListBoxPratosEdit.DataSource = controladorMenuRefeicao.UpdateListBoxPratos();
            checkedListBoxExtrasEdit.DataSource = controladorMenuRefeicao.UpdateListBoxExtras();
            checkedListBoxPratos.DataSource = controladorMenuRefeicao.UpdateListBoxPratos();
            checkedListBoxExtras.DataSource = controladorMenuRefeicao.UpdateListBoxExtras();
            listBoxMenuRefeicoes.DataSource = controladorMenuRefeicao.UpdateListBoxMenus();

        }

        //Adicionar menu a base de dados
        private void btnAdicionarMenu_Click(object sender, EventArgs e)
        {
            //ir buscar os pratos selecionados para completar o menu
            List<Prato> lista = MenuRefeicao.GetCheckedItems<Prato>(checkedListBoxPratos);

            //verificar que pelo menos 1 prato foi selecionado
            if (lista.Count == 0)
            {
                MessageBox.Show("Escolha pelo menos um Prato");
                return;
            }

            controladorMenuRefeicao.AddMenu(dateTimePicker.Value, numericUpDownQtddDisponivel.Value, numericUpDownPrecoEstudante.Value, numericUpDownPrecoProfessor.Value, checkedListBoxPratos, checkedListBoxExtras);

            // limpar os checks da checkbox
            for (int i = 0; i < checkedListBoxPratos.Items.Count; i++)
            {   
                checkedListBoxPratos.SetItemChecked(i, false);
            }

            for (int i = 0; i < checkedListBoxExtras.Items.Count; i++)
            {
                checkedListBoxExtras.SetItemChecked(i, false);
            }

            listBoxMenuRefeicoes.DataSource = controladorMenuRefeicao.UpdateListBoxMenus();
        }

        //return para o menu principal
        private void btnReturn_Click(object sender, EventArgs e)
        {
            menuPrincipal.panelShowForm.Controls.Clear();

            menuPrincipal.sidebar.Enabled = true;
        }

        //Preencher os campos da zona de edicao do menu de acordo com o menu selecinado
        private void listBoxMenuRefeicoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuRefeicao menuAtual = (MenuRefeicao)listBoxMenuRefeicoes.SelectedItem;

            // limpar os checks da checkbox
            for (int i = 0; i < checkedListBoxPratosEdit.Items.Count; i++)
            {
                checkedListBoxPratosEdit.SetItemChecked(i, false);
            }

            // limpar os checks da checkbox
            for (int i = 0; i < checkedListBoxExtrasEdit.Items.Count; i++)
            {
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
                    break;
                
                // Verificar se o prato esta presente na lista de pratos do menuAtual
                if (menuAtual.Pratos.Any(p => p.Id == prato.Id))
                {
                    //Check do prato se estiver presente no menuAtual
                    checkedListBoxPratosEdit.SetItemChecked(i, true);
                }
            }

            // Percorrer todos os itens da checkboxlist
            for (int i = 0; i < checkedListBoxExtrasEdit.Items.Count; i++)
            {
                Extra extra = (Extra)checkedListBoxExtrasEdit.Items[i];
                
                if (menuAtual.Extras == null)
                    break;


                // Verificar se o extra esta presente na lista de extras do menuAtual
                if (menuAtual.Extras.Any(p => p.Id == extra.Id))
                {
                   // Check do extra se estiver presente no menuAtual
                    checkedListBoxExtrasEdit.SetItemChecked(i, true);
                }
            }
        }

        //Atualizar a base de dados com os dados do menu atualizados
        private void btnAtualizarMenu_Click(object sender, EventArgs e)
        {
            controladorMenuRefeicao.UpdateMenu(dateTimePickerEdit.Value, numericUpDownQtddDisponivelEdit.Value, numericUpDownPrecoEstudanteEdit.Value, numericUpDownPrecoProfessorEdit.Value, checkedListBoxPratosEdit, checkedListBoxExtrasEdit, (MenuRefeicao)listBoxMenuRefeicoes.SelectedItem);
            listBoxMenuRefeicoes.DataSource = controladorMenuRefeicao.UpdateListBoxMenus();
        }

        //remover um menu da base de dados
        private void btnRemoverMenu_Click(object sender, EventArgs e)
        {
            controladorMenuRefeicao.RemoveMenu((MenuRefeicao)listBoxMenuRefeicoes.SelectedItem);

            listBoxMenuRefeicoes.DataSource = controladorMenuRefeicao.UpdateListBoxMenus();
        }
    }
}
