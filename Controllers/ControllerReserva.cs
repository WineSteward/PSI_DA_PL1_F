﻿using PSI_DA_PL1_F.Models;
using PSI_DA_PL1_F.Views;
using System.Collections.Generic;
using System.Linq;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ControllerReserva : Controller
    {
        public ControllerReserva()
        {

        }

        public List<Prato> GetPratos()
        {
            using (var db = new CantinaContext())
            {
                return db.Pratos.Where(p => p.Ativo).ToList();
            }
        }

        public List<Extra> GetExtras()
        {
            using (var db = new CantinaContext())
            {
                return db.Extras.ToList();
            }
        }
    }
}

