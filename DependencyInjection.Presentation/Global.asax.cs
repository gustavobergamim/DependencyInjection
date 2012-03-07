using System;
using System.Web;
using Castle.Windsor;

namespace DependencyInjection.Presentation
{
    public class Global : HttpApplication, IGlobal
    {
        #region IGlobal Members

        private static IWindsorContainer _container;
        public IWindsorContainer Container
        {
            get
            {
                return _container;
            }
        }

        #endregion

        protected void Application_Start(object sender, EventArgs e)
        {
            _container = new WindsorContainer();
            _container.Install(new CastleWindsorInstaller());
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