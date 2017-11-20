using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.IdentityModel.Protocols;

namespace TestNetCore.Controllers
{
    public class BaseController : Controller, IActionFilter
    {
		public const string			SESSION_LANGUAGE = "LOCALIZABLE_PAGE_LANGUAGE";
		public const string			REQUEST_LANGUAGE = "lingua";
		public const string			WEBCONFIG_DEFAULT_LANGUAGE_KEY = "LinguaDefault";

		// serve per evitare loop infiniti in caso di mancanza di permessi
		public const string			AUTH_CHECK = "AUTH_CHECK";
		public const string			VIEWDATA_USER = "USER";

		//private Utente				currentUser;

		//protected Utente			CurrentUser => currentUser;

		/*protected string CurrentCulture
		{
			get {
				string	ret = ConfigurationManager<>.AppSettings[ WEBCONFIG_DEFAULT_LANGUAGE_KEY ];
				string	sessValue = Session[ SESSION_LANGUAGE ] as string;

				if( !string.IsNullOrWhiteSpace( sessValue ))
					ret = sessValue;

				return ret;
			}
		}*/
 
		/*void IActionFilter.OnActionExecuting( ActionExecutingContext filterContext )
		{
			base.OnActionExecuting( filterContext );

            Utenti.ControlloSessione( filterContext.HttpContext );

			if( filterContext.ActionDescriptor.GetCustomAttributes( typeof( ExpiresAttribute ), true ).Length <= 0 )
				filterContext.HttpContext.Response.Cache.SetCacheability( HttpCacheability.NoCache );
	
			Session[ AUTH_CHECK ] = null;

			currentUser = Utenti.GetUtente( filterContext.HttpContext.Session );

			if( filterContext.ActionDescriptor.GetCustomAttributes( typeof( AllowEveryoneAttribute ), true ).Length <= 0 ) {

				if( currentUser == null )
					filterContext.Result = Redirect( FormsAuthentication.LoginUrl + "?ReturnUrl=" + Server.UrlEncode( filterContext.HttpContext.Request.RawUrl ));
			}
		}*/

		/*protected override void Initialize( RequestContext requestContext )
		{
			string	lingua = requestContext.HttpContext.Request[ REQUEST_LANGUAGE ];
			Thread	thread = Thread.CurrentThread;

			base.Initialize( requestContext );

			ValidateRequest = false;

			if( string.IsNullOrWhiteSpace( lingua )) {

				lingua = Session[ SESSION_LANGUAGE ] as string;

				if( string.IsNullOrWhiteSpace( lingua ) && ( CurrentUser != null ) && 
					Array.Exists( Utenti.GetLingueDisponibili(), l => l == CurrentUser.Lingua ))
					lingua = CurrentUser.Lingua;

				if( string.IsNullOrWhiteSpace( lingua ))
					lingua = ConfigurationManager.AppSettings[ WEBCONFIG_DEFAULT_LANGUAGE_KEY ];
			}

			if( !string.IsNullOrWhiteSpace( lingua )) {

				Session[ SESSION_LANGUAGE ] = lingua;

				thread.CurrentCulture   = GetCultureInfo( lingua );
				thread.CurrentUICulture = GetCultureInfo( lingua );
			}
		}*/

		/*protected override void ExecuteCore()
		{
			PrepareToExecute();

		    base.ExecuteCore();
		}*/

		/*protected override IAsyncResult BeginExecuteCore( AsyncCallback callback, object state )
		{
			PrepareToExecute();

			return base.BeginExecuteCore( callback, state );
		}*/

		/*private void PrepareToExecute()
		{
			KSSSOClient.HandlePostAuth();
            Utenti.ControlloSessione( HttpContext );

			currentUser = Utenti.GetUtente( HttpContext.Session );

            ViewBag.User = currentUser;
		}*/

		/*protected override void OnException( ExceptionContext filterContext )
		{
			if(( filterContext != null ) && !filterContext.ExceptionHandled ) {
				RouteData		routeData = filterContext.RouteData;
				Exception		ex = filterContext.Exception ?? new Exception( "No further information exists." );
				HandleErrorInfo	errorInfo = new HandleErrorInfo( ex,
				               									 (string)routeData.Values[ "controller" ],
				               									 (string)routeData.Values[ "action" ] );

				if( ex is AccessoNegatoException )
					filterContext.Result = View( "Error403", errorInfo );
				else
					filterContext.Result = View( "Error", errorInfo );

				try {
					HttpException httpEx = filterContext.Exception as HttpException;

					filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;

					filterContext.HttpContext.Response.StatusCode = httpEx?.GetHttpCode() ?? 500;
				}
				catch( HttpException ) {
					// capita se gli headers sono già stati inviati per questa richiesta
				}

				filterContext.ExceptionHandled = true;
			}
		}*/

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