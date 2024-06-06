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
    public partial class FormClientes : Form
    {
        FormMenuPrincipal menuPrincipal;
        public FormClientes(FormMenuPrincipal menuPrincipal)
        {
            InitializeComponent();

            this.menuPrincipal = menuPrincipal;
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
