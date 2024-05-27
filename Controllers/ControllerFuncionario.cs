using PSI_DA_PL1_F.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ControllerFuncionario
    {

        public void RegistarFuncionario(string username, string nome, string nif)
        {
            using (var db = new CantinaContext())
            {

                var funcionario = new Funcionario { Username = username, Nome = nome, NIF = nif};
                db.Funcionarios.Add(funcionario);
                db.SaveChanges();
                // acho que o professor disse que n a messagebox no controlller
                MessageBox.Show("Novo funcionario na base de dados");
            }
        }

    }
}
