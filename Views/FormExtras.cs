using PSI_DA_PL1_F.Controllers;
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
        }

        private void btnAdicionarExtra_Click(object sender, EventArgs e)
        {
            controladorExtras.AddExtra(textBoxDescricao.Text, numericUpDownPreco.Value);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
