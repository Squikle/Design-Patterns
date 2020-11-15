using System;
using System.Collections.Generic;
using Flyweight.Classes;

namespace Flyweight
{
    class Program
    {
        static void Main()
        {
            MechanicFactory mechanicFactory = new MechanicFactory();
            List<Mechanic> mechanics = new List<Mechanic>
            {
                mechanicFactory.GetMechanicBySpecialization("универсал"),
                mechanicFactory.GetMechanicBySpecialization("пикап"),
                mechanicFactory.GetMechanicBySpecialization("пикап"),
                mechanicFactory.GetMechanicBySpecialization("пикап"),
                mechanicFactory.GetMechanicBySpecialization("универсал")
            };

            foreach (var mechanic in mechanics)
                mechanic.Work();

            Console.ReadKey();
        }
    }
}
