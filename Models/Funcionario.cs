using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Models
{
    public class Funcionario : Utilizador
    {
        public string Username { get; set; }

        public override string ToString()
        {
            return Username + " | " + Nome;
        }

        public static bool ValidarNif(string input)
        {
            // Check if the input contains only numbers using Regex
            if (!Regex.IsMatch(input, @"^\d+$"))
            {
                return false;
            }

            // Check if the length of the input is within the specified range
            if (input.Length == 9)
            {
                return false;
            }

            return true;
        }

    }
}
