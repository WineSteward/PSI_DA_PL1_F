using PSI_DA_PL1_F.Models;
using PSI_DA_PL1_F.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ControllerPratos
    {
        CantinaContext db;

        public ControllerPratos(CantinaContext db)
        {
            this.db = db;
        }

        public void AddPrato(string descricao, TipoPrato tipo, bool estado)
        {
            db.Pratos.Add(new Prato(descricao, estado, tipo));
            db.SaveChanges();
        }

        public List<Prato> UpdateListBoxPratos()
        {
            List<Prato> listaPratos = new List<Prato>();

            listaPratos = db.Pratos.ToList<Prato>();

            return listaPratos;
        }

        public List<TipoPrato> UpdateListBoxTipo()
        {
            List<TipoPrato> listaTipoPrato = Prato.GetAllTipos();

            return listaTipoPrato;
        }

        public void RemovePrato(object pratoAtual)
        {
            if (pratoAtual is Prato)
                db.Pratos.Remove((Prato)pratoAtual);

            db.SaveChanges();
        }

        public Prato FindPrato(Prato pratoAtual)
        {
            return db.Pratos.Find(pratoAtual.Id);
        }

        public void UpdatePrato(string descricao ,bool ativo, Prato pratoAtual)
        {
            pratoAtual = db.Pratos.Find(pratoAtual.Id);

            pratoAtual.Descricao = descricao;
            pratoAtual.Ativo = ativo;

            db.SaveChanges();
        }

    }
}
