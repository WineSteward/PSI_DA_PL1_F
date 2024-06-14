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

        public decimal precoEstudante { get; set; }

        public decimal precoProfessor { get; set; }

        public List<Extra> Extras { get; set; } //MENU NAO TEM MAXIMO DE EXTRAS podemos ter gelatina, pudim, fruta, bolo... tudo no mesmo dia mas na RESERVA SO PODEM ESCOLHER ATE 3

        public List<Prato> Pratos { get; set; }  //MENU NAO TEM MAXIMO DE PRATOS podemos bifana, bacalhau a bras, frango com massa..., tudo no mesmo dia mas na RESERVA SO PODEM ESCOLHER 1
    }
}
