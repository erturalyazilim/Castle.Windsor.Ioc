using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IDriver drive = IoCUtil.Resolve<IDriver>();
            drive.Drive();
            IVehicle bus = IoCUtil.Resolve<IVehicle>();
            bus.Passenger();
        }
    }
}
