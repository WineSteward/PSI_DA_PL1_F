using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    internal class Item
    {
        public int ID { get; set; }

        private int Total;

        private int total
        {
            get { return total; }
            set { total = value; }
        }

        private string description;

        public string descricao
        {
            get { return description; }
            set { description = value; }
        }

        public Fatura fatura;
    }
}
