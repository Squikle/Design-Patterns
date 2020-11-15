using System;
using Singleton.Classes;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            SingleTon singleTon = SingleTon.Create("Test");
            Console.WriteLine(singleTon.Name);
            Console.WriteLine(singleTon.CreatedAt);

            singleTon = SingleTon.Create("Test1");
            Console.WriteLine(singleTon.Name);
            Console.WriteLine(singleTon.CreatedAt);

            singleTon = SingleTon.GetInstance();
            Console.WriteLine(singleTon.Name);
            Console.WriteLine(singleTon.CreatedAt);

            Console.ReadKey();
        }
    }
}
