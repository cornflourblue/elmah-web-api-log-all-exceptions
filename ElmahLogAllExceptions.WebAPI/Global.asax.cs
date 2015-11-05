using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ElmahLogAllExceptions.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteTable.Routes.Ignore("{resource}.axd/{*pathInfo}"); 
            
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
