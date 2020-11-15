namespace Facade
{
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
}