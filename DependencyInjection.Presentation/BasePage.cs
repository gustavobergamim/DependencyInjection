using System.Web;
using System.Web.UI;
using Castle.Windsor;

namespace DependencyInjection.Presentation
{
    public class BasePage : Page
    {
        public IWindsorContainer Container
        {
            get
            {
                return (HttpContext.Current.ApplicationInstance as IGlobal).Container;
            }
        }
    }
}