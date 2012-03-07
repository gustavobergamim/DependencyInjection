using System;
using DependencyInjection.Business;

namespace DependencyInjection.Presentation
{
    public partial class Default : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var business = Container.Resolve<IPeopleBusiness>();
            var teste = business.GetPeople();
        }
    }
}