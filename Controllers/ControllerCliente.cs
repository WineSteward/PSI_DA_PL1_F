using PSI_DA_PL1_F.Models;
using PSI_DA_PL1_F.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ControllerCliente : Controller
    {
        CantinaContext db;
        FormMenuPrincipal menuPrincipal;
        public ControllerCliente(FormMenuPrincipal menuPrincipal, CantinaContext db)
        {
            this.db = db;
            this.menuPrincipal = menuPrincipal;
        }

        public void AddEstudante(string nome, string nif, decimal saldo, string numeroEstudante)
        {
            db.Estudantes.Add(new Estudante(nome, nif, saldo, numeroEstudante));
            db.SaveChanges();
        }

        public void AddProfessor(string nome, string nif, decimal saldo, string emailProfessor)
        {
            db.Professores.Add(new Professor(nome, nif, saldo, emailProfessor));
            db.SaveChanges();
        }

        public void CloseForm()
        {
            menuPrincipal.panelShowForm.Controls.Clear();

            menuPrincipal.sidebar.Enabled = true;
        }

        public List<Cliente> UpdateListBox()
        {
            List <Cliente> listaClientes = new List<Cliente>();

            listaClientes = db.Estudantes.ToList<Cliente>();

            listaClientes.AddRange(db.Professores.ToList<Cliente>());

            return listaClientes;
        }

        public void RemoveCliente(object clienteAtual)
        {
            if (clienteAtual is Estudante)
                db.Estudantes.Remove((Estudante)clienteAtual);
            else
                db.Professores.Remove((Professor)clienteAtual);
            
            db.SaveChanges();
        }

        public Cliente FindCliente(Cliente clienteAtual)
        {
            if (clienteAtual is Estudante)
                return db.Estudantes.Find(clienteAtual.Id);
            else
                return db.Professores.Find(clienteAtual.Id);

        }

        public void UpdateEstudante(string nome, string nif, decimal saldo, string numeroEstudante, Cliente clienteAtual)
        {
           Estudante estudanteAtual =  db.Estudantes.Find(clienteAtual.Id);
            
            estudanteAtual.Nome = nome;
            estudanteAtual.NIF = nif;
            estudanteAtual.Saldo = saldo;
            estudanteAtual.NumeroEstudante = numeroEstudante;

            db.SaveChanges();
        
        }

        public void UpdateProfessor(string nome, string nif, decimal saldo, string emailProfessor, Cliente clienteAtual)
        {
            Professor professorAtual = db.Professores.Find(clienteAtual.Id); //pedido para ser professor quando era estudante

            professorAtual.Nome = nome;
            professorAtual.NIF = nif;
            professorAtual.Saldo = saldo;
            professorAtual.EmailProfessor = emailProfessor;

            db.SaveChanges();

        }
    }
}
