using System;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            IPhone opPhone = new Oneplus8Phone();
            Console.WriteLine("Цена " + opPhone.Name + ": " + opPhone.Cost);

            opPhone = new Phone5G(opPhone);
            Console.WriteLine("Цена " + opPhone.Name + ": " + opPhone.Cost);

            opPhone = new PhoneDualCamera(opPhone);
            Console.WriteLine("Цена " + opPhone.Name + ": " + opPhone.Cost);

            Console.WriteLine();

            IPhone samsungPhone = new GalaxyS10Phone();
            Console.WriteLine("Цена " + samsungPhone.Name + ": " + samsungPhone.Cost);

            samsungPhone = new Phone5G(samsungPhone);
            Console.WriteLine("Цена " + samsungPhone.Name + ": " + samsungPhone.Cost);

            samsungPhone = new PhoneDualCamera(samsungPhone);
            Console.WriteLine("Цена " + samsungPhone.Name + ": " + samsungPhone.Cost);

            Console.ReadKey();
        }

        interface IPhone
        {
            int Cost { get; }
            string Brand { get; }
            string Name { get; }
        }

        abstract class Phone : IPhone
        {
            public abstract string Name { get; }
            public abstract string Brand { get; }
            public abstract int Cost { get; }
        }

        class GalaxyS10Phone : Phone
        {
            public override int Cost => 700;
            public override string Name => "Galaxy S10";
            public override string Brand => "Samsung";

        }

        class Oneplus8Phone : Phone
        {
            public override int Cost => 600; 
            public override string Name => "Oneplus 8";
            public override string Brand => "Oneplus";

        }

        abstract class PhoneDecorator : Phone
        {
            protected IPhone Phone;
            public override string Brand => Phone.Brand;
            protected PhoneDecorator(IPhone phone)
            {
                Phone = phone;
            }
        }

        class Phone5G : PhoneDecorator
        {
            public override int Cost
                => this.Phone.Cost + 80;

            public override string Name => this.Phone.Name + " 5g";
            public Phone5G(IPhone phone) : base(phone) { }
        }

        class PhoneDualCamera : PhoneDecorator
        {
            public override int Cost
                => this.Phone.Cost + 100;
            public override string Name => this.Phone.Name + " Dual Camera";
            public PhoneDualCamera(IPhone phone) : base(phone) { }
        }
    }
}
