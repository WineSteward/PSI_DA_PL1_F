using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PSI_DA_PL1_F.Models
{
    public class Cliente : Utilizador
    {
        public decimal Saldo { get; set; }
    }

}
