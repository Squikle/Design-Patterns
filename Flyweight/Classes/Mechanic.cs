using System;

namespace Flyweight.Classes
{
    class Mechanic
    {
        public string SpecializedAt { get; }

        public Mechanic(string specialization)
        {
            SpecializedAt = specialization;
        }
        public void Work()
        {
            Console.WriteLine($"Работает механик, специализирующийся на классе {SpecializedAt}");
        }
    }
}
