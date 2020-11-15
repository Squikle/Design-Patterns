namespace Facade
{
    class MyPc : PersonalComputer
    {
        public MyPc(IMotherBoard motherBoard, IMemory memory, ICpu cpu)
            : base(motherBoard, memory, cpu) {}
    }
}