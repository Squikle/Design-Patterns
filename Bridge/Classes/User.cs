using Bridge.Abstractions;
using Bridge.Interfaces;

namespace Bridge.Classes
{
    class User : Person
    {
        public User(IDevice device)
            : base(device) { }
        protected override void DoWork()
        {
            System.Console.WriteLine("Пользователь потребляет контент");
        }
    }
}