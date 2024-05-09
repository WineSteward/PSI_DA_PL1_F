using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    internal class Estudante : Cliente
    {
        private string numero_estudante;

        public string numeroEstudante
        {
            get { return numero_estudante; }
            set { numero_estudante = value;}
        }
    }
}
