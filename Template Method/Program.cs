using System;
using Template_Method.Abstractions;
using Template_Method.Implementers;

namespace Template_Method
{
    class Program
    {
        static void Main()
        {
            Player player = new Player(new GamingConsole());
            player.Play();

            player.GamingDevice = new GamingPc();
            player.Play();

            Console.ReadKey();
        }
    }
}
