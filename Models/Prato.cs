using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    internal class Prato
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; } 

        public enum TipoPrato
        {
            Carne,
            Peixe,
            Vegetariano
        }

        public TipoPrato Tipo { get; set; }

    }
}
