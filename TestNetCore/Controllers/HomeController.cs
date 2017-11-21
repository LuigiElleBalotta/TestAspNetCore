using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestNetCore.BO;
using TestNetCore.Models;
using TestNetCore.Models.DB;

namespace TestNetCore.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {

            byte[] ret;

			if( !HttpContext.Session.TryGetValue( "User", out ret ))
				return RedirectToAction( "Index", "Registration" );

            Utente user = JsonConvert.DeserializeObject<Utente>( System.Text.UTF8Encoding.UTF8.GetString( ret ));

            ViewBag.User = user;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult ListaUtenti()
        {
            Home bo = new Home();

            Utente ut = JsonConvert.DeserializeObject<Utente>( HttpContext.Session.GetString( "User" ));

            if( ut != null )
                return View( bo.GetListaUtenti());

            return RedirectToAction( "DoRegistration", "Registration" );
        }
    }
}
