using System;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Classes
{
    class Sword : IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Sword Hit!");
        }
    }
}
