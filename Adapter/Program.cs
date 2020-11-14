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

        class Human
        {
            public void InputData(ITypingData typingData)
            {
                typingData.Type();
            }
        }

        interface ITypingData
        {
            void Type();
        }

        class Keyboard : ITypingData
        {
            public void Type()
            {
                Console.WriteLine("Клавиатура печатает");
            }
        }

        interface IWriting
        {
            void Write();
        }

        class Pen : IWriting
        {
            public void Write()
            {
                Console.WriteLine("Ручка пишет");
            }
        }

        class WritingToTypingData : ITypingData
        {
            private IWriting _pen;

            public WritingToTypingData(IWriting pen)
            {
                _pen = pen;
            }
            public void Type()
            {
                _pen.Write();
            }
        }
    }
}
