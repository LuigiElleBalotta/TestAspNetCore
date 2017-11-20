using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestNetCore.Models.Registration;
using Lappa.ORM.Misc;
using Microsoft.IdentityModel.Protocols;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using TestNetCore.BO;
using TestNetCore.Models.MySQL;

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