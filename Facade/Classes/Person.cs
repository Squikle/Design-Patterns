using Facade.Abstractions;

namespace Facade.Classes
{
    class Person
    {
        public void DoWork(PersonalComputer pc)
        {
            pc.StartPc();
            pc.Calculate();
            pc.ShutdownPc();
        }
    }
}