using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    public class Estudante : Cliente
    {
        public string NumeroEstudante { get; set; }


        public Estudante() { }

        public Estudante(string nome, string nif, decimal saldo, string numeroEstudante)
        {
            this.Nome = nome;
            this.NIF = nif;
            this.Saldo = saldo;
            this.NumeroEstudante = numeroEstudante;
        }


        public override string ToString()
        {
            return Nome + " | Estudante";
        }

    }
}
