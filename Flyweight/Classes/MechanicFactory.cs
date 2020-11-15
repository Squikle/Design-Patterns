using System;
using System.Collections.Generic;
using System.Linq;

namespace Flyweight.Classes
{
    class MechanicFactory
    {
        private Dictionary<string, Mechanic> _mechanics;

        public MechanicFactory()
        {
            _mechanics = new Dictionary<string, Mechanic>();
        }

        public Mechanic GetMechanicBySpecialization(string specialization)
        {
            Mechanic mechanic = _mechanics.FirstOrDefault(x => x.Key == specialization).Value;

            if (mechanic != null)
                return mechanic;

            Console.WriteLine($"Нанимаем механика специализирующегося на классе {specialization}...");
            mechanic = new Mechanic(specialization);
            _mechanics.Add(specialization, mechanic);
            return mechanic;
        }
    }
}
