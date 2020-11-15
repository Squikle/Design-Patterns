using System;
using Patterns.Interfaces;

namespace Patterns.Classes
{
    class Car : IVehicle
    {
        public void Ride()
        {
            Console.WriteLine("Car ride");
        }
    }
}