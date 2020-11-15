namespace Facade
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