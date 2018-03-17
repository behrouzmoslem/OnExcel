using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using onExcel.DataAccess.MSSql;

namespace OnExcel.Composition
{
    public class DataAccessInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Classes.FromAssemblyContaining<SqlUnitOfWork>()
                .Pick()
                .WithServiceAllInterfaces()
                .LifestyleTransient());
        }
    }
}