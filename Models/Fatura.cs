using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    internal class Fatura
    {
        public int ID;

        private int Total;
    
        private int total
        {
            get { return total; }
            set { total = value; }
        }

        private DateTime DataHora;

        public DateTime dataHora
        {
            get { return dataHora; }
            set { dataHora = value; }
        }
    
    }
}
