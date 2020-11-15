using System;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Classes
{
    class PlasticArmor : IArmor
    {
        public void Protect()
        {
            Console.WriteLine("Plastic Armor Protect!");
        }
    }
}
