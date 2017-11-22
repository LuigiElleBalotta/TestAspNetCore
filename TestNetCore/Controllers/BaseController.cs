using System;
using System.Globalization;
using System.Threading;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using TestNetCore.Models.DB;
using TestNetCore.Models.User;

namespace TestNetCore.Controllers
{
    public class BaseController : Controller, IActionFilter
    {
        private static string PAGE_TITLE = "";

        public override void OnActionExecuting( ActionExecutingContext context )
        {
            ViewBag.User = GetUserFromSession( context.HttpContext.Session );

            base.OnActionExecuting( context );
        }

        internal void SetPageTitle( string pageTitle )
        {
            PAGE_TITLE = pageTitle;
        }

        public override void OnActionExecuted( ActionExecutedContext context )
        {
            ViewData["Title"] = PAGE_TITLE;

            base.OnActionExecuted( context );
        }

        protected JsonResult JsonOK()
		{
			return Json( "" );
		}

        internal UserModel GetUserFromSession( ISession session )
        {
            byte[] userByte;
            string userString = String.Empty;
            UserModel ret = null;

            if( session.TryGetValue( "User", out userByte )) {
                ret = JsonConvert.DeserializeObject<UserModel>( System.Text.Encoding.UTF8.GetString( userByte ));
            }

            return ret;
        }

		protected JsonResult JsonError( string msg )
		{
			return Json( new { ErrorMessage = msg } );
		}

		public static CultureInfo GetNumberFormat()
		{
			CultureInfo			ci = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
			NumberFormatInfo	nfi = ci.NumberFormat;

			nfi.NumberGroupSeparator        = ".";
			nfi.NumberDecimalSeparator      = ",";
			ci.DateTimeFormat.TimeSeparator = ":";
			
			return ci;
		}

        public static CultureInfo GetFormNumberFormat()
		{
			CultureInfo			ci = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
			NumberFormatInfo	nfi = ci.NumberFormat;

			nfi.NumberGroupSeparator        = "";
			nfi.NumberDecimalSeparator      = ".";
			ci.DateTimeFormat.TimeSeparator = ":";
			
			return ci;
		}

		public static CultureInfo GetCultureInfo( string lang )
		{
			CultureInfo			ci = new CultureInfo( lang );
			NumberFormatInfo	nfi = ci.NumberFormat;

			nfi.NumberGroupSeparator        = "";
			nfi.NumberDecimalSeparator      = ".";
			ci.DateTimeFormat.TimeSeparator = ":";
			
			return ci;
		}
	}
}