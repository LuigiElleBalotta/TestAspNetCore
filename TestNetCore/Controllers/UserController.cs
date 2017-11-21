using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestNetCore.Controllers
{
    public class UserController : BaseController
    {
        public ActionResult Profile()
        {
            return View( "Profile" );
        }
    }
}