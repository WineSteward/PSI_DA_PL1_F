using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    public class Fatura
    {
        public int Id { get; set; }

        public decimal Total { get; set; }
    
        public DateTime DataHora { get; set; }

        public Prato Prato { get; set; }

        public List<Item> Items { get; set; }

        public Fatura() { }

        public Fatura(DateTime data, decimal total, decimal precoPrato, Prato prato, List<Extra> extras)
        {
            Total = total;
            DataHora = data;
            Prato = prato;
            Items = new List<Item>();

            Item itemPrato = new Item(prato.Descricao, precoPrato);
            
            foreach(Extra extra in extras)
            {
                Item itemExtra = new Item(extra.Descricao, extra.Valor);
                
                Items.Add(itemExtra);
            }
        }
    }
}
