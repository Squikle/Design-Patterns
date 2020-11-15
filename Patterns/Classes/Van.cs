using System;

namespace Patterns
{
    class Van : IVehicle
    {
        public void Ride()
        {
            Console.WriteLine("Van ride");
        }
    }
}