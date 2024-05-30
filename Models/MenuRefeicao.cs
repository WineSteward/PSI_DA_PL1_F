using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    public class MenuRefeicao
    {
        public int Id { get; set; }

        public DateTime DataHora { get; set; }

        public int Stock { get; set; }

        public float precoEstudante { get; set; }

        public float precoProfessor { get; set; }

        public Extra[] Extras { get; set; }

        public Prato Prato { get; set; }
    }
}
