using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace HuaheeArtist
{
    public class Global : System.Web.HttpApplication
    {
        public const string CSA = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                   AttachDbFilename=|DataDirectory|\Artist.mdf;
                                   Integrated Security=True";

        public const string CSC = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                   AttachDbFilename=|DataDirectory|\Customer.mdf;
                                   Integrated Security=True";

        public const string CSP = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                   AttachDbFilename=|DataDirectory|\Product.mdf;
                                   Integrated Security=True";
        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}