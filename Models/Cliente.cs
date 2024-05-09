using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    internal class Cliente : Utilizador
    {
        private float Saldo;

        public float saldo
        {
            get { return Saldo; }
            set { Saldo = value; }
        }

    }
}
