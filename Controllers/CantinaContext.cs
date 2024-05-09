using PSI_DA_PL1_F.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PSI_DA_PL1_F.Controllers
{
    internal class CantinaContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<Estudante> Estudantes { get; set; }

        public DbSet<Professor> Professores { get; set; }

    }
}
