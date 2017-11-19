using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{


    public interface IDriver
    {
        void Drive();

    }

    public class CarDriver : IDriver
    {
        public void Drive()
        {
            Console.WriteLine("araba sürülüyor");
        }
    }

    public class BusDriver : IDriver
    {
        public void Drive()
        {
            Console.WriteLine("Otobüs sürülüyor");
        }
    }

    public interface IVehicle
    {
        void Passenger();

    }

    public class BusPassenger : IVehicle
    {
        public void Passenger()
        {
            Console.WriteLine("Otobüs ile geziliyor");
        }
    }
   public class CarPassenger : IVehicle
    {
        public void Passenger()
        {
            Console.WriteLine("Araba ile geziliyor");
        }
    }

    class Organizator
    {
        IDriver _driver = null;
        IVehicle _vehicle = null;
        public  Organizator(IDriver driver, IVehicle vehicle)
        {
            _driver = driver;
            _vehicle = vehicle;
        }

        public void MakeTrip()
        {
            _vehicle.Passenger();
            
            _driver.Drive();
            
        }
    }

    public  static  class Program
    {
        static void Main()
        {
            Organizator organizator = new Organizator(new BusDriver(), new BusPassenger());
            organizator.MakeTrip();
        }

    }

}
