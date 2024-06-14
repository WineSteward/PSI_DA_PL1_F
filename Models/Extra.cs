using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    public class Extra
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public bool Ativo { get; set; }

        public Extra(string descricao, decimal valor)
        {
            this.Descricao = descricao;
            this.Valor = valor;
        }

    }


}
