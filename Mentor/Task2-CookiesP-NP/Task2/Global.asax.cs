using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Task2
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //Application["TotalApps"] = 0;
            //Application["TotalSessions"] = 0;
            //Application["TotalApps"] = (int)Application["TotalApps"] + 1;
        }
        void Session_Start(object sender, EventArgs e)
        {
            //Application["TotalSessions"] = (int)Application["TotalSessions"] + 1;
        }
        void Session_End(object sender, EventArgs e)
        {
            //Application["TotalSessions"] = (int)Application["TotalSessions"] - 1;
        }
    }
}