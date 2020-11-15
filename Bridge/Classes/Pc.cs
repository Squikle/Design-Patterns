using Bridge.Interfaces;

namespace Bridge.Classes
{
    class Pc : IDevice
    {
        public void Start()
        {
            System.Console.WriteLine("Компьютер включается");
        }
        public void Shutdown()
        {
            System.Console.WriteLine("Компьютер выключается");
        }
    }
}