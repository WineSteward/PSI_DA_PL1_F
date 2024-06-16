using PSI_DA_PL1_F.Models;
using PSI_DA_PL1_F.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ControllerCliente : Controller
    {
        CantinaContext db;
        public ControllerCliente(CantinaContext db)
        {
            this.db = db;
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

        public List<Cliente> UpdateListBox()
        {
            List<Cliente> listaClientes;

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

        public List<Cliente> FindCliente(string nomeCliente)
        {
            return db.Clientes.Where(c => c.Nome == nomeCliente).ToList<Cliente>();

        }

        public List<Cliente> FindCliente(ListBox tipoCliente)
        {
            if (tipoCliente.Items.Count == 0)
                return null;

            List<Cliente> lista = null;

            foreach (string cliente in tipoCliente.SelectedItems)
            {
                if (cliente == "Estudante")
                {
                    lista = db.Estudantes.ToList<Cliente>();
                    return lista;
                }
                else if (cliente == "Professor")
                {
                    lista = db.Professores.ToList<Cliente>();
                    return lista;
                }
            }

            // If no specific type was found in the ListBox items, return an empty list
            return lista ?? new List<Cliente>();
        }


        public List<Cliente> FindCliente(string nomeCliente, ListBox tipoCliente)
        {
            if (tipoCliente.Items.Count == 0)
                return null;

            List<Cliente> lista = null;

            foreach (string cliente in tipoCliente.SelectedItems)
            {
                if (cliente == "Estudante")
                {
                    lista = db.Estudantes.Where(c => c.Nome == nomeCliente).ToList<Cliente>();
                    return lista;
                }
                else if (cliente == "Professor")
                {
                    lista = db.Professores.Where(c => c.Nome == nomeCliente).ToList<Cliente>();
                    return lista;
                }
            }

            // If no specific type was found in the ListBox items, return an empty list
            return lista ?? new List<Cliente>();
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
