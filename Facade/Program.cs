using System;

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

    class Person
    {
        public void DoWork(PersonalComputer pc)
        {
            pc.StartPc();
            pc.Calculate();
            pc.ShutdownPc();
        }
    }

    interface IMotherBoard
    {
        void Start();
        void Shutdown();
    }

    interface IMemory
    {
        void Save();
        void Load();
    }

    interface ICpu
    {
        void Calculate();
    }

    class MotherBoardB250M : IMotherBoard
    {
        public void Start()
        {
            Console.WriteLine("Start PC");
        }

        public void Shutdown()
        {
            Console.WriteLine("Shutdown PC");
        }
    }

    class Memory120Gb : IMemory
    {
        public void Save()
        {
            Console.WriteLine("Save Data");
        }

        public void Load()
        {
            Console.WriteLine("Load Data");
        }
    }

    class IntelI5 : ICpu
    {
        public void Calculate()
        {
            Console.WriteLine("Calculate Info");
        }
    }

    abstract class PersonalComputer
    {
        protected IMotherBoard MotherBoard;
        protected IMemory Memory;
        protected ICpu Cpu;
        protected PersonalComputer(IMotherBoard motherBoard, IMemory memory, ICpu cpu)
        {
            MotherBoard = motherBoard;
            Memory = memory;
            Cpu = cpu;
        }

        public void StartPc()
        {
            MotherBoard.Start();
            Memory.Load();
        }
        public void ShutdownPc()
        {
            Memory.Save();
            MotherBoard.Shutdown();
        }
        public void Calculate()
        {
            Cpu.Calculate();
        }
    }
    class MyPc : PersonalComputer
    {
        public MyPc(IMotherBoard motherBoard, IMemory memory, ICpu cpu)
            : base(motherBoard, memory, cpu) {}
    }
}
