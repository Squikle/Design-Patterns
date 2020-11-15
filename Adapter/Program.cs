using System;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            Human human = new Human();
            ITypingData keyboard = new Keyboard();
            human.InputData(keyboard);

            Console.WriteLine();

            IWriting pen = new Pen();
            ITypingData typingDataPen = new WritingToTypingData(pen);
            human.InputData(typingDataPen);

            Console.ReadKey();
        }
    }
}
