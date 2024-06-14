using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    public class Prato
    {
        public int Id {  get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public TipoPrato Tipo { get; set; }


        public static List<TipoPrato> GetAllTipos()
        {
            List<TipoPrato> lista = new List<TipoPrato>();

            foreach (TipoPrato tipo in Enum.GetValues(typeof(TipoPrato)))
            {
                lista.Add(tipo);
            }

            return lista;
        }

        public override string ToString()
        {
            return Descricao + " | " + Tipo.ToString();
        }

        public Prato() { }

        public Prato(string descricao, bool estado, TipoPrato tipo)
        {
            Descricao = descricao;
            Ativo = estado;
            Tipo = tipo;
        }
    }


    public enum TipoPrato
    {
        Carne,
        Peixe,
        Vegetariano
    }
}
