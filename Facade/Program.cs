using System;
using Facade.Classes;
using Facade.Interfaces;

namespace Facade
{
    class Program
    {
        static void Main()
        {
            IMotherBoard myMotherBoard = new MotherBoardB250M();
            IMemory myMemory = new Memory120Gb();
            ICpu myCpu = new IntelI5();

            MyPc myPc = new MyPc(myMotherBoard, myMemory, myCpu);

            Person me = new Person();
            me.DoWork(myPc);

            Console.ReadKey();
        }
    }
}
