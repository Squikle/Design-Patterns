using System;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Classes
{
    class Bow : IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Bow Hit!");
        }
    }
}
