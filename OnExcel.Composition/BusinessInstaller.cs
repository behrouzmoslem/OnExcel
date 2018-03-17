using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using onExcel.Business;

namespace OnExcel.Composition
{
    public class BusinessInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyContaining<IPatientService>()
                .Pick()
                .WithServiceAllInterfaces()
                .LifestyleTransient()); 
        }
    }
}