using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    public class Professor : Cliente
    {
        public string EmailProfessor { get; set; }

        public Professor() { }
        public Professor(string nome, string nif, decimal saldo, string emailProfessor)
        {
            this.Nome = nome;
            this.NIF = nif;
            this.Saldo = saldo;
            this.EmailProfessor = emailProfessor;
        }

        public override string ToString()
        {
            return Nome + " | Professor";
        }
    }
}
