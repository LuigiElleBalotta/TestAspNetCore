using System.Globalization;
using System.Threading;
using Microsoft.AspNetCore.Mvc;

namespace TestNetCore.Controllers
{
    public class BaseController : Controller
    {

		protected JsonResult JsonOK()
		{
			return Json( "" );
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