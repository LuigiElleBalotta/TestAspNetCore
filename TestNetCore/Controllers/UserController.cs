using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            UserModel ut = GetUserFromSession( HttpContext.Session );

            Profilo ret = bo.GetProfilo( ut.Utente.ID );

            ProfiloModel dati = new ProfiloModel
                                {
                                    Utente = ut.Utente,
                                    Profilo = ret
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
    }
}