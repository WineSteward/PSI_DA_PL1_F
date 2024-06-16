using PSI_DA_PL1_F.Controllers;
using PSI_DA_PL1_F.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Views
{
    public partial class FormVistaSemanal : Form
    {
        FormMenuPrincipal menuPrincipal;
        ControllerVistaSemanal controladorVistaSemanal;
        public FormVistaSemanal(FormMenuPrincipal menuPrincipal)
        {
            InitializeComponent();

            this.menuPrincipal = menuPrincipal;

            controladorVistaSemanal = new ControllerVistaSemanal(menuPrincipal.db);

            //preencher a listbox dias por default para mostrara a semana atual, acho que abre logo no dia atual -> facil entao
            List<DateTime> week = controladorVistaSemanal.GetSemana(dateTimePicker);
            // limpar listbox
            listBoxDias.Items.Clear();

            // adicionar os dias a listbox
            foreach (DateTime day in week)
            {
                listBoxDias.Items.Add(day);
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           List<DateTime> week = controladorVistaSemanal.GetSemana(dateTimePicker);

            // limpar listbox
            listBoxDias.Items.Clear();

            // adicionar os dias a listbox
            foreach (DateTime day in week)
            {
                listBoxDias.Items.Add(day);
            }
        }

        private void listBoxDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxMenu.Items.Clear();

            if(listBoxDias.SelectedItem == null)
                return;

            MenuRefeicao menu = controladorVistaSemanal.FindMenu((DateTime)listBoxDias.SelectedItem);

            if (menu == null)
                return;

            foreach(Prato prato in menu.Pratos)
            {
                listBoxMenu.Items.Add(prato.ToString());
            }
        }
       
        private void btnReturn_Click(object sender, EventArgs e)
        {
            menuPrincipal.panelShowForm.Controls.Clear();

            menuPrincipal.sidebar.Enabled = true;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            MenuRefeicao menu = controladorVistaSemanal.FindMenu((DateTime)listBoxDias.SelectedItem);

            menuPrincipal.panelShowForm.Controls.Clear();

            FormReserva formReserva = new FormReserva(menuPrincipal, menu);
        }

        private void btnCriarMenu_Click(object sender, EventArgs e)
        {

            if (listBoxDias.SelectedItem == null)
            {
                MessageBox.Show("Selcione um dia antes de prosseguir");
                return;
            }

            menuPrincipal.panelShowForm.Controls.Clear();

            FormMenuRefeicao form = new FormMenuRefeicao(menuPrincipal, (DateTime)listBoxDias.SelectedItem);
        }
    }
}
