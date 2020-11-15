namespace Bridge
{
    class Program
    {
        static void Main()
        {
            IDevice console = new Console();
            IDevice pc = new Pc();
            IPerson person = new Developer(console);

            person.UseDevice();

            System.Console.WriteLine();

            person.Device = pc;
            person.UseDevice();

            System.Console.WriteLine();

            person = new User(pc);
            person.UseDevice();

            System.Console.WriteLine();

            person.Device = console;
            person.UseDevice();

            System.Console.ReadKey();
        }
    }

    interface IPerson
    {
        IDevice Device { get; set; }
        void UseDevice();
    }

    abstract class Person : IPerson
    {
        public IDevice Device { get; set; }

        protected Person(IDevice device)
        {
            Device = device;
        }
        public void UseDevice()
        {
            Device.Start();
            DoWork();
            Device.Shutdown();
        }
        protected abstract void DoWork();
    }

    class User : Person
    {
        public User(IDevice device)
            : base(device) { }
        protected override void DoWork()
        {
            System.Console.WriteLine("Пользователь потребляет контент");
        }
    }

    class Developer : Person
    {
        public Developer(IDevice device)
            : base(device) { }
        protected override void DoWork()
        {
            System.Console.WriteLine("Разработчик отлаживает программу");
        }
    }

    interface IDevice
    {
        void Start();
        void Shutdown();
    }

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
