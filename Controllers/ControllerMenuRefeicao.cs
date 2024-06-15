using PSI_DA_PL1_F.Models;
using PSI_DA_PL1_F.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ControllerMenuRefeicao
    {
        CantinaContext db;
        List<Extra> escolhaExtras;
        List<Prato> escolhaPratos;
        List<Extra> novaEscolhaExtras;
        List<Prato> novaEscolhaPratos;
        public ControllerMenuRefeicao(CantinaContext db)
        {
            this.db = db;
        }

        public List<Extra> UpdateListBoxExtras()
        {
            List<Extra> listaExtras = db.Extras.ToList();

            return listaExtras;
        }

        public List<MenuRefeicao> UpdateListBoxMenus()
        {
            List<MenuRefeicao> listaMenus = db.MenuRefeicoes.ToList();

            return listaMenus;
        }

        public List<Prato> UpdateListBoxPratos()
        {
            List<Prato> listaPratos = db.Pratos.ToList();

            return listaPratos;
        }

        public void AddMenu(DateTime diaHora, decimal quantidade, decimal precoEstudante, decimal precoProfessor, CheckedListBox pratos, CheckedListBox extras)
        {
            escolhaExtras = Extra.GetCheckedItems(extras);

            escolhaPratos = Prato.GetCheckedItems(pratos);

            int quantidadeDisponivel = (int)quantidade;

            // Obrigar que o menu tenha a hora do almoço e nao a atual
            DateTime dia = new DateTime(diaHora.Year, diaHora.Month, diaHora.Day, 12, 00, 0);

            db.MenuRefeicoes.Add(new MenuRefeicao(dia, quantidadeDisponivel, precoEstudante, precoProfessor, escolhaExtras, escolhaPratos));
            db.SaveChanges();
        }

        public void UpdateMenu(DateTime diaHora, decimal quantidade, decimal precoEstudante, decimal precoProfessor, CheckedListBox pratos, CheckedListBox extras, MenuRefeicao menuAtual)
        {
            novaEscolhaExtras = Extra.GetCheckedItems(extras);

            novaEscolhaPratos = Prato.GetCheckedItems(pratos);

            int quantidadeDisponivel = (int)quantidade;

            // Obrigar que o menu tenha a hora do almoço e nao a atual
            DateTime dia = new DateTime(diaHora.Year, diaHora.Month, diaHora.Day, 12, 00, 0);

            menuAtual.precoProfessor = precoProfessor;
            menuAtual.precoEstudante = precoEstudante;

            menuAtual.DataHora = dia;

            menuAtual.Quantidade = quantidadeDisponivel;

            menuAtual.Pratos = novaEscolhaPratos;
            menuAtual.Extras = novaEscolhaExtras;

            db.SaveChanges();
        }
    }
}
