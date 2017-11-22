using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestNetCore.Models.Registration;
using TestNetCore.BO;
using TestNetCore.Models.Login;

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

                LoginModel lm = new LoginModel
                                {
                                    Email = response.Utente.Email,
                                    Password = response.Utente.Password
                                };

				return RedirectToAction( "DoLogin", "Login", new{ form = lm } );
			}

			return View( "Index" );
		}
    }
}