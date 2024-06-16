﻿using PSI_DA_PL1_F.Models;
using PSI_DA_PL1_F.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ControllerMenuRefeicao
    {
        CantinaContext db;
       
        public ControllerMenuRefeicao(CantinaContext db)
        {
            this.db = db;
        }

        public List<Extra> UpdateListBoxExtras()
        {
            List<Extra> listaExtras = db.Extras.ToList<Extra>();

            return listaExtras;
        }

        public List<MenuRefeicao> UpdateListBoxMenus()
        {

            List<MenuRefeicao> listaMenus = db.MenuRefeicoes
                          .Include(m => m.Pratos) //include dos pratos
                          .Include(m => m.Extras) //include dos extras
                          .ToList<MenuRefeicao>();

            return listaMenus;
        }

        public List<Prato> UpdateListBoxPratos()
        {
            List<Prato> listaPratos = db.Pratos.ToList<Prato>();

            return listaPratos;
        }

        public void AddMenu(DateTime diaHora, decimal quantidade, decimal precoEstudante, decimal precoProfessor, CheckedListBox pratos, CheckedListBox extras)
        {
            List<Extra> escolhaExtras = MenuRefeicao.GetCheckedItems<Extra>(extras);

            List<Prato> escolhaPratos = MenuRefeicao.GetCheckedItems<Prato>(pratos);

            int quantidadeDisponivel = (int)quantidade;

            // Obrigar que o menu tenha a hora do almoço e nao a atual
            DateTime dia = new DateTime(diaHora.Year, diaHora.Month, diaHora.Day, 12, 00, 0);

            db.MenuRefeicoes.Add(new MenuRefeicao(dia, quantidadeDisponivel, precoEstudante, precoProfessor, escolhaExtras, escolhaPratos));
            db.SaveChanges();
        }

        public void UpdateMenu(DateTime diaHora, decimal quantidade, decimal precoEstudante, decimal precoProfessor, CheckedListBox pratos, CheckedListBox extras, MenuRefeicao menuAtual)
        {

            List<Extra> novaEscolhaExtras = MenuRefeicao.GetCheckedItems<Extra>(extras);

            List<Prato> novaEscolhaPratos = MenuRefeicao.GetCheckedItems<Prato>(pratos);

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

        public void RemoveMenu(MenuRefeicao menuAtual)
        {
            db.MenuRefeicoes.Remove(menuAtual);
            db.SaveChanges();
        }
    }
}
