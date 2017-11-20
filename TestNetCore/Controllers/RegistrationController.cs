using Microsoft.AspNetCore.Mvc;
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

			if( bo.DoRegistration( data ))
				View( "Success" );

			return View( "Index" );
		}
    }
}