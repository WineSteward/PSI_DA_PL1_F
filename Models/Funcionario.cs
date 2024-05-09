using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    internal class Funcionario : Utilizador
    {
        private string Username;

        public string username
        {
            get { return Username; }
            set { Username = value; }
        }
    }
}
