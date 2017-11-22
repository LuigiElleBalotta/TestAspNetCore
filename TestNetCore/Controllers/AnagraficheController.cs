using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestNetCore.BO;
using TestNetCore.Models.DB;

namespace TestNetCore.Controllers
{
    public class AnagraficheController : BaseController
    {
        public IActionResult Strumenti()
        {
            Anagrafiche bo = new Anagrafiche();

            Strumento[] strumenti = bo.GetListaStrumenti();

            return View( "Strumenti", strumenti );
        }

        public JsonResult AddInstrument( string descrizione )
        {
            Anagrafiche bo = new Anagrafiche();

            bo.AddInstrument( descrizione );

            return JsonOK();
        }

        public JsonResult UpdateInstrument( string descrizione, int id )
        {
            Anagrafiche bo = new Anagrafiche();

            bo.UpdateInstrument( descrizione, id );

            return JsonOK();
        }
    }
}