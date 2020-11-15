using Bridge.Classes;
using Bridge.Interfaces;

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
}
