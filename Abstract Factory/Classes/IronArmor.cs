using System;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Classes
{
    class IronArmor : IArmor
    {
        public void Protect()
        {
            Console.WriteLine("Iron Armor Protect!");
        }
    }
}
