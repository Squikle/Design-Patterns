using System;
using Decorator.Classes;
using Decorator.Interfaces;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            IPhone opPhone = new Oneplus8Phone();
            Console.WriteLine("Цена " + opPhone.Name + ": " + opPhone.Cost);

            opPhone = new Phone5G(opPhone);
            Console.WriteLine("Цена " + opPhone.Name + ": " + opPhone.Cost);

            opPhone = new PhoneDualCamera(opPhone);
            Console.WriteLine("Цена " + opPhone.Name + ": " + opPhone.Cost);

            Console.WriteLine();

            IPhone samsungPhone = new GalaxyS10Phone();
            Console.WriteLine("Цена " + samsungPhone.Name + ": " + samsungPhone.Cost);

            samsungPhone = new Phone5G(samsungPhone);
            Console.WriteLine("Цена " + samsungPhone.Name + ": " + samsungPhone.Cost);

            samsungPhone = new PhoneDualCamera(samsungPhone);
            Console.WriteLine("Цена " + samsungPhone.Name + ": " + samsungPhone.Cost);

            Console.ReadKey();
        }
    }
}
