using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    public class Multa
    {
        public int Id { get; set; }

        public decimal Valor { get; set; }

        public decimal NumeroHoras { get; set; }

        public Multa() { }

        public Multa(decimal numeroHoras, decimal valor)
        {
            this.Valor = valor;
            this.NumeroHoras = numeroHoras;
        }

        public override string ToString()
        {
            return NumeroHoras.ToString() + "Horas | " + Valor.ToString() + "€";
        }
    }
}









