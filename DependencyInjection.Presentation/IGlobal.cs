using Castle.Windsor;

namespace DependencyInjection.Presentation
{
    public interface IGlobal
    {
        IWindsorContainer Container { get; }
    }
}
