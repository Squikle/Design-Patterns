using System;

namespace Patterns
{
    class Car : IVehicle
    {
        public void Ride()
        {
            Console.WriteLine("Car ride");
        }
    }
}