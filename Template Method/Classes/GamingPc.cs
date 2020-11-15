using System;
using Template_Method.Abstractions;

namespace Template_Method.Classes
{
    class GamingPc : Playable
    {
        public override void Play()
        {
            Console.WriteLine("Игра на игровом компьютере");
        }
    }
}