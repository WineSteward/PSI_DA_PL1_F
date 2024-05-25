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
        private ReservaController reservaControlador;

        public FormReserva()
        {
            InitializeComponent();
            reservaControlador = new ReservaController();
            MostrarPratos();
            MostrarExtras();
            
            listBoxTipo.SelectedIndexChanged += listBoxTipo_SelectedIndexChanged;
        }

        private void MostrarPratos()
        {
            var pratos = reservaControlador.GetPratos();
            listBoxTipo.Items.Clear();
            foreach (var prato in pratos)
            {

                listBoxTipo.Items.Add(prato.Tipo.ToString());
            }
        }

        private void MostrarExtras()
        {
            var extras = reservaControlador.GetExtras();
            checkedListBoxExtras.Items.Clear();
            foreach (var extra in extras)
            {
                
                checkedListBoxExtras.Items.Add(extra.Descricao);
            }
        }

        private void listBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTipo.SelectedItem == null)
            {
                return;
            }

            string tipoSelecionado = listBoxTipo.SelectedItem.ToString();

            // Esta parte foi por charGPT pq não sabia como fazer vê se queres mudar
            var prato = reservaControlador.GetPratos()
                .FirstOrDefault(p => p.Tipo.ToString() == tipoSelecionado);

        
            if (prato != null)
            {
                textBoxDescricaoPrato.Text = prato.Descricao;
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (listBoxTipo.SelectedItem == null)
            {
                MessageBox.Show("Selecione um tipo de prato.");
                return;
            }

        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem == null)
            {
                return;
            }

            
        }

        
    }
}
