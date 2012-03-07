using System.Configuration;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using DependencyInjection.BusinessImpl;
using DependencyInjection.RepositoryImpl;

namespace DependencyInjection.Presentation
{
    public class CastleWindsorInstaller : IWindsorInstaller
    {
        #region IWindsorInstaller Members

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                AllTypes
                .FromAssemblyContaining<PeopleBusinessImpl>()
                .Where(t => t.Name.EndsWith("BusinessImpl"))
                .WithService
                .FirstInterface());

            string connectionString = ConfigurationManager.ConnectionStrings["connStringTest"].ConnectionString;

            container.Register(
                AllTypes
                .FromAssemblyContaining<PeopleRepositoryImpl>()
                .Where(t => t.Name.EndsWith("RepositoryImpl"))
                .WithService
                .FirstInterface()
                .Configure(r => r.LifeStyle.PerWebRequest
                .DependsOn(new
                               {
                                   connString = connectionString
                               })));
        }

        #endregion
    }
}