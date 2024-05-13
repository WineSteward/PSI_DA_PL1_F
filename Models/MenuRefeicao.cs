using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    internal class MenuRefeicao
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime DataHora;

        public DateTime dataHora
        {
            get { return DataHora; }
            set { DataHora = value; }
        }

        private int Stock;

        public int stock
        {
            get { return Stock; }
            set { Stock = value; }
        }

        public float precoEstudante;

        public float precoProfessor;

    }
}
