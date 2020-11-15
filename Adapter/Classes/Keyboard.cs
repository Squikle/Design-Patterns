using System;
using Adapter.Interfaces;

namespace Adapter.Classes
{
    class Keyboard : ITypingData
    {
        public void Type()
        {
            Console.WriteLine("Клавиатура печатает");
        }
    }
}
