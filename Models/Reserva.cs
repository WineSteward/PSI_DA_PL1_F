using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Models
{
    public class Reserva
    {
        public int Id {  get; set; }

        public decimal Total { get; set; }

        public Cliente Cliente { get; set; }

        public Multa Multa { get; set; }

        public MenuRefeicao Menu { get; set; }
        
        public List<Extra> Extras { get; set; } //minimo de 1 maximo de 3

        public Prato Prato { get; set; } //so podem escolher 1

        public bool Ativo { get; set; }


        public Reserva() { }


        public Reserva(Cliente cliente, MenuRefeicao menu, List<Extra> extras, Prato prato, decimal total)
        {
            Cliente = cliente;
            Menu = menu;
            Extras = extras;
            Prato = prato;
            Total = total;
            Ativo = true;
        }

        public Reserva(Cliente cliente, Multa multa, MenuRefeicao menu, List<Extra> extras, Prato prato, decimal total)
        {
            Cliente = cliente;
            Multa = multa;
            Menu = menu;
            Extras = extras;
            Prato = prato;
            Total = total;
            Ativo = true;
        }


        public static List<Extra> GetCheckedItems(CheckedListBox checkedListBox)
        {
            List<Extra> checkedItemsList = new List<Extra>();
            
            foreach (var item in checkedListBox.CheckedItems)
            {
                checkedItemsList.Add((Extra)item);
            }
            return checkedItemsList;
        }

        public override string ToString()
        {
            return Cliente.Nome + " | " + Menu.DataHora.ToString();
        }


        public string ToStringExtended()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome do Cliente: {Cliente.Nome}");
            sb.AppendLine($"Dia e Hora da Reserva: {Menu.DataHora.ToString()}");
            sb.AppendLine($"Prato: {Prato.ToString()}");
            sb.AppendLine("Extras:");

            foreach (var extra in Extras)
            {
                sb.AppendLine($"- {extra}");
            }
            return sb.ToString();
        }


        public string GetFileName()
        {
            return Cliente.Nome + "_" + $"{Menu.DataHora:dd_MM_yyyy}.txt";
        }
    }
}
