namespace Bridge
{
    class Console : IDevice
    {
        public void Start()
        {
            System.Console.WriteLine("Консоль включается");
        }

        public void Shutdown()
        {
            System.Console.WriteLine("Консоль выключается");
        }
    }
}