using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace OnExcel.Composition
{
    public class HttpEndpointInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyNamed("onExcel.HttEndpoint")
                .Pick()
                .WithService
                .DefaultInterfaces()
                .LifestyleTransient()
            );
        }
    }
}