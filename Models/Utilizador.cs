using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    public class Utilizador
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string NIF { get; set; }

        public static bool ValidarNif(string input)
        {
            //Usar um regex para verificar se todos os caracteres da string sao numeros
            if (!Regex.IsMatch(input, @"^\d+$"))
            {
                return false;
            }

            // Verificar se o tamanho do nif é correto
            if (input.Length != 9)
            {
                return false;
            }

            return true;
        }
    }
}
