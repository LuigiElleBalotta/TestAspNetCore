using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestNetCore.BO;
using TestNetCore.Models;

namespace TestNetCore.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
			if( !HttpContext.User.Identity.IsAuthenticated )
				return RedirectToAction( "Index", "Registration" );

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

            return View( bo.GetListaUtenti());
        }
    }
}
