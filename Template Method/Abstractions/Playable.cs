using System;
using Template_Method.Interfaces;

namespace Template_Method.Abstractions
{
    abstract class Playable : IPlayable
    {
        public void Enable()
        {
            Console.WriteLine("Запуск устройства");
        }
        public void Disable()
        {
            Console.WriteLine("Выключение устройства");
        }
        public abstract void Play();
    }
}