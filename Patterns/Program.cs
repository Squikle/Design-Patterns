using System;

namespace Patterns
{
    class Program
    {
        static void Main()
        {
            IMechanic mechanic = new VanMechanic();
            var van = mechanic.BuildVehicle();
            van.Ride();

            mechanic = new CarMechanic();
            var car = mechanic.BuildVehicle();
            car.Ride();

            Console.ReadKey();
        }
    }

    interface IMechanic
    {
        IVehicle BuildVehicle();
    }

    class VanMechanic : IMechanic
    {
        public IVehicle BuildVehicle()
        {
            return new Van();
        }
    }
    class CarMechanic : IMechanic
    {
        public IVehicle BuildVehicle()
        {
            return new Car();
        }
    }

    interface IVehicle
    {
        void Ride();
    }

    class Van : IVehicle
    {
        public void Ride()
        {
            Console.WriteLine("Van ride");
        }
    }

    class Car : IVehicle
    {
        public void Ride()
        {
            Console.WriteLine("Car ride");
        }
    }
}
