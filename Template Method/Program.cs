using System;
using Template_Method.Classes;

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
