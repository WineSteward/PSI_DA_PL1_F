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
    public partial class FormMenuRefeicao : Form
    {
        FormMenuPrincipal menuPrincipal;
        public FormMenuRefeicao(FormMenuPrincipal menuPrincipal)
        {
            InitializeComponent();

            this.menuPrincipal = menuPrincipal;
        }

        private void btnAdicionarMenu_Click(object sender, EventArgs e)
        {
            DateTime dataMenu = dateTimePicker.Value;
        }
    }
}
