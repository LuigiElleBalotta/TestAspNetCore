using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestNetCore.Models.Registration;
using TestNetCore.BO;

namespace TestNetCore.Controllers
{
    public class RegistrationController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult DoRegistration( RegisterViewModel data )
		{

			Registration bo = new Registration();

            RegistrationResponse response = bo.DoRegistration( data );

			if( response.Inserted ) {
				//@todo doLogin and load dashboard
                HttpContext.Session.SetString( "User", JsonConvert.SerializeObject( response.Utente ) );

				return RedirectToAction( "ListaUtenti", "Home" );
			}

			return View( "Index" );
		}
    }
}