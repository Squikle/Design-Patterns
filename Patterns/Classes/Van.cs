using System;
using Patterns.Interfaces;

namespace Patterns.Classes
{
    class Van : IVehicle
    {
        public void Ride()
        {
            Console.WriteLine("Van ride");
        }
    }
}