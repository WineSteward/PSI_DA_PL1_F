using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    public class Prato
    {
        public int Id {  get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public TipoPrato Tipo { get; set; }

    }

    public enum TipoPrato
    {
        Carne,
        Peixe,
        Vegetariano
    }
}
