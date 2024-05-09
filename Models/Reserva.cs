using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
