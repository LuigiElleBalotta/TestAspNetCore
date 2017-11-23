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

        public JsonResult DeleteInstrument( int[] ids )
        {
            Anagrafiche bo = new Anagrafiche();

            bo.DeleteInstrument( ids );

            return JsonOK();
        }
    }
}