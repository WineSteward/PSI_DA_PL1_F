using PSI_DA_PL1_F.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ControllerVistaSemanal : Controller
    {
        CantinaContext db;
        public ControllerVistaSemanal(CantinaContext db)
        {
            this.db = db;
        }

        public List<DateTime> GetSemana(DateTimePicker dateTimePicker)
        {
            // Get da data selecionada
            DateTime selectedDate = dateTimePicker.Value;

            // Calculo do inicio da semana, Segunda-Feira por default
            DateTime startOfWeek = selectedDate.AddDays(-(int)selectedDate.DayOfWeek + (int)DayOfWeek.Monday);
            if (selectedDate.DayOfWeek == DayOfWeek.Sunday)
            {
                startOfWeek = startOfWeek.AddDays(-7);
            }

            // Create a list to store the dates of the week
            List<DateTime> daysOfWeek = new List<DateTime>();

            // Populate the list with the dates of the week
            for (int i = 0; i < 7; i++)
            {
                daysOfWeek.Add(startOfWeek.AddDays(i));
            }

            return daysOfWeek;
        }


        public MenuRefeicao FindMenu(DateTime dia)
        {
            //redundancia da hora pois queremos é o menu do dia mes ano
            DateTime searchDate = dia.Date;

            //procurar pelo menu com o dia mes ano e ignorar as horas

            MenuRefeicao menu = db.MenuRefeicoes
                          .Include(m => m.Pratos) //include dos pratos
                          .Include(m=> m.Extras) //include dos extras
                          .FirstOrDefault(m => DbFunctions.TruncateTime(m.DataHora) == searchDate);

            return menu;
        }


    }
}
