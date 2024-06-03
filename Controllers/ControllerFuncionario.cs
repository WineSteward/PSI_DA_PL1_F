using PSI_DA_PL1_F.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ControllerFuncionario : Controller
    {

        public void RegistarFuncionario(string username, string nome, string nif, CantinaContext db)
        {
            var novoFuncionario = new Funcionario { Username = username, Nome = nome, NIF = nif };
            db.Funcionarios.Add(novoFuncionario);
            db.SaveChanges();
        }

        public void RemoveFuncionario(CantinaContext db, Funcionario funcionarioAtual)
        {
            if (funcionarioAtual == null)
                return;

            db.Funcionarios.Remove(funcionarioAtual);
            db.SaveChanges();
        }

        public List<Funcionario> UpdateListBoxFuncionario(CantinaContext db)
        {
            List<Funcionario> listaFuncionarios = db.Funcionarios.ToList<Funcionario>();
            
            return listaFuncionarios;
        }


    }
}
