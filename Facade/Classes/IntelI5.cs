using System;
using Facade.Interfaces;

namespace Facade.Classes
{
    class IntelI5 : ICpu
    {
        public void Calculate()
        {
            Console.WriteLine("Calculate Info");
        }
    }
}