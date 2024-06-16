using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Models
{
    public class MenuRefeicao
    {
        public int Id { get; set; }

        public DateTime DataHora { get; set; }

        public int Quantidade { get; set; }

        public decimal precoEstudante { get; set; }

        public decimal precoProfessor { get; set; }

        public List<Extra> Extras { get; set; } //MENU NAO TEM MAXIMO DE EXTRAS podemos ter gelatina, pudim, fruta, bolo... tudo no mesmo dia mas na RESERVA SO PODEM ESCOLHER ATE 3

        public List<Prato> Pratos { get; set; }  //MENU NAO TEM MAXIMO DE PRATOS podemos bifana, bacalhau a bras, frango com massa..., tudo no mesmo dia mas na RESERVA SO PODEM ESCOLHER 1

        public static List<T> GetCheckedItems<T>(CheckedListBox checkedListBox) where T : class
        {
            List<T> checkedItemsList = new List<T>();

            foreach (var item in checkedListBox.CheckedItems)
            {
                if (item is T)
                {
                    checkedItemsList.Add(item as T);
                }
            }
            return checkedItemsList;
        }

        public override string ToString()
        {
            return "Menu do Dia: " + DataHora.ToString();
        }

        public MenuRefeicao() { }

        public MenuRefeicao(DateTime dataHora, int quantidade, decimal precoEstudante, decimal precoProfessor, List<Extra> extras, List<Prato> pratos)
        {
            DataHora = dataHora;
            Quantidade = quantidade;
            this.precoEstudante = precoEstudante;
            this.precoProfessor = precoProfessor;
            Extras = extras;
            Pratos = pratos;
        }
    }
}
