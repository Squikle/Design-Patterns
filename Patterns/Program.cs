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
}
