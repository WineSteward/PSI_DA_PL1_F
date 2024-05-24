using PSI_DA_PL1_F.Controllers;
using PSI_DA_PL1_F.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI_DA_PL1_F
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var db = new CantinaContext())
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Views.FormMenuPrincipal(db));

                /*
                   Funcionario Alberto = new Funcionario{NIF = "123345", Nome = "Alberto", Username = "" };
                   db.Funcionarios.Add(Alberto);

                    db.SaveChanges();
              */
            }

            

        }
    }
}
