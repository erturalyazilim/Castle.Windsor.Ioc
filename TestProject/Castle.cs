using Castle.Core.Resource;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public static class IoCUtil
    {
        private static IWindsorContainer _container = null;
        private static IWindsorContainer Container
        {
            get
            {
                if (_container == null)
                {
                    _container = BootstrapContainer();
                }
                return _container;
            }
        }
        private static IWindsorContainer BootstrapContainer()
        {

            //if you want xlm configuration is active then remove  the comment which is below

            //return new WindsorContainer().Register( Component.For<IDriver>().ImplementedBy<BusDriver>(), Component.For<IVehicle>().ImplementedBy<BusPassenger>());
            return new WindsorContainer(new XmlInterpreter(new ConfigResource("castle")));
        }
        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
