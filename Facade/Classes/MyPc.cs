using Facade.Abstractions;
using Facade.Interfaces;

namespace Facade.Classes
{
    class MyPc : PersonalComputer
    {
        public MyPc(IMotherBoard motherBoard, IMemory memory, ICpu cpu)
            : base(motherBoard, memory, cpu) {}
    }
}