using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Models
{
    internal class Reserva
    {
        private int ID;
        public int id
        {
            get { return ID; }
            set { ID = value; }
        }

        public Cliente Cliente { get; set; }

        public Multa Multa { get; set; }

        public MenuRefeicao Menu { get; set; }
        
        public List<Extra> Extras { get; set; } //minimo de 1 maximo de 3

        public Prato Prato { get; set; }


    }
}
