using System;

namespace Facade
{
    class IntelI5 : ICpu
    {
        public void Calculate()
        {
            Console.WriteLine("Calculate Info");
        }
    }
}