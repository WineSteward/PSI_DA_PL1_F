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

        public DbSet<Fatura> Faturas { get; set;}

        public DbSet<Reserva> Reservas { get; set; }

        public DbSet<MenuRefeicao> MenuRefeicoes { get; set; }

        public DbSet<Extra> Extras { get; set; }

        public DbSet<Prato> Pratos { get; set; }

        public DbSet<Item> Itens { get; set; }

    }


}
