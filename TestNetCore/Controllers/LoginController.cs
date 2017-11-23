using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestNetCore.BO;
using TestNetCore.Constants;
using TestNetCore.Models.Login;
using TestNetCore.Models.User;

namespace TestNetCore.Controllers
{
    public class LoginController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DoLogin( LoginModel form )
        {
            Login bo = new Login();

            LoginResponse ret = bo.CheckLogin( form );

            if( ret.Status == Misc.LoginStatus.OK ) {
                //@Todo: set session value and redirect to the dashboard
                string userStr = JsonConvert.SerializeObject( ret.Utente );
                HttpContext.Session.SetString( "User", userStr );
                return RedirectToAction( "Index", "Home" );
            }

            return RedirectToAction( "Index" );
            
        }

        public static void Logout( HttpContext ctx )
        {
            ctx.Session?.Clear();
        }

        public static void ControlloSessione( HttpContext ctx )
        {
            UserModel ut = null;

            UserController bo = new UserController();

            if( ctx.Session != null ) {

                ut = bo.GetUserFromSession( ctx.Session );

                if( ut == null ) {
					
                    Logout( ctx );
                }
            }

            if( ut == null )
                Logout( ctx );
        }
    }
}