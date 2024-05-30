using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    public class Item
    {
        public int Id { get; set; }

        public int Total { get; set; }

        public string Descricao { get; set; }

        public Fatura fatura { get; set; }
    }
}
