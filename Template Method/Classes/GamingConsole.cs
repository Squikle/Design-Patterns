using System;
using Template_Method.Abstractions;

namespace Template_Method.Classes
{
    class GamingConsole : Playable
    {
        public override void Play()
        {
            Console.WriteLine("Игра на игровой консоли");
        }
    }
}