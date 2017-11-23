using System;
using Microsoft.AspNetCore.Mvc;
using TestNetCore.BO;
using TestNetCore.Models.DB;
using TestNetCore.Models.User;

namespace TestNetCore.Controllers
{
    public class UserController : BaseController
    {

        public ActionResult Profile()
        {
            SetPageTitle("Profilo");

            User bo = new User();
            Anagrafiche boA = new Anagrafiche();

            UserModel ut = GetUserFromSession( HttpContext.Session );

            Profilo ret = bo.GetProfilo( ut.Utente.ID );

            Strumento[] strumenti = boA.GetListaStrumenti();

            ProfiloStrumento[] profiloStrumenti = bo.GetStrumentiCollegati( ret.IDUtente );

            int[] strumentiCollegati = Array.ConvertAll( profiloStrumenti, x => x.IDStrumento );

            ProfiloModel dati = new ProfiloModel
                                {
                                    Utente = ut.Utente,
                                    Profilo = ret,
                                    Strumenti = strumenti,
                                    StrumentiCollegati = strumentiCollegati
                                };

            return View( "Profile", dati );
        }

        public JsonResult UpdateBiography( string content )
        {
            User bo = new User();

            bo.UpdateBiography( content, GetUserFromSession( HttpContext.Session ).Utente.ID );

            return JsonOK();
        }

        public JsonResult UpdateGenres( string content )
        {
            User bo = new User();

            bo.UpdateGenres( content, GetUserFromSession( HttpContext.Session ).Utente.ID );

            return JsonOK();
        }

        public JsonResult UpdateArtists( string content )
        {
            User bo = new User();

            bo.UpdateArtists( content, GetUserFromSession( HttpContext.Session ).Utente.ID );

            return JsonOK();
        }

        public JsonResult UpdateSetup( string content )
        {
            User bo = new User();

            bo.UpdateSetup( content, GetUserFromSession( HttpContext.Session ).Utente.ID );

            return JsonOK();
        }

        public JsonResult UpdateCovers( string content )
        {
            User bo = new User();

            bo.UpdateCovers( content, GetUserFromSession( HttpContext.Session ).Utente.ID );

            return JsonOK();
        }

        public JsonResult UpdatePlayedInstruments( int[] strumentiSelezionati )
        {
            User bo = new User();

            bo.UpdatePlayedInstruments( strumentiSelezionati, GetUserFromSession( HttpContext.Session ).Utente.ID );

            return JsonOK();
        }
    }
}