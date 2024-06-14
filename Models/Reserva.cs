using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Models
{
    public class Reserva
    {
        public int Id {  get; set; }

        public Cliente Cliente { get; set; }

        public Multa Multa { get; set; }

        public MenuRefeicao Menu { get; set; }
        
        public Extra[] Extras { get; set; } //minimo de 1 maximo de 3

        public Prato Prato { get; set; } //so podem escolher 1


    }
}
