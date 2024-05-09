using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    internal class Utilizador
    {
        private int ID;

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }

        private string Name;

        public string nome
        {
            get { return Name; }
            set { Name = value; }
        }

        private string NIF;

        public string nif
        {
            get { return NIF; }
            set { NIF = value; }
        }
    }
}
