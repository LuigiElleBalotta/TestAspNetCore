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

            Utente ut = GetUserFromSession( HttpContext.Session );

            Profilo ret = bo.GetProfilo( ut.ID );

            ProfiloModel dati = new ProfiloModel
                                {
                                    Utente = ut,
                                    Profilo = ret
                                };

            return View( "Profile", dati );
        }

        public JsonResult UpdateBiography( string content )
        {
            User bo = new User();

            bo.UpdateBiography( content, GetUserFromSession( HttpContext.Session ).ID );

            return JsonOK();
        }
    }
}