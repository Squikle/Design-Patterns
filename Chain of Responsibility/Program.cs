using System;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main()
        {
            IPhone xiaomiPhone = new XiaomiPhone(true);
            IPhone oneplusPhone = new OneplusPhone(true);

            Console.WriteLine($"Сиоме {(xiaomiPhone.Broken ? "сломан" : "починен")}");
            Console.WriteLine($"OnePlus {(oneplusPhone.Broken ? "сломан" : "починен")}");

            IAuthorizedPhoneRepairer iphoneRepairer = new IphoneRepairer();
            IAuthorizedPhoneRepairer samsungRepairer = new SamsungRepairer();
            IAuthorizedPhoneRepairer xiaomiRepairer = new XiaomiRepairer();
            iphoneRepairer.Successor = samsungRepairer;
            samsungRepairer.Successor = xiaomiRepairer;

            Console.WriteLine("\nОбращаемся в сервисы:");
            iphoneRepairer.TryRepair(ref xiaomiPhone);
            iphoneRepairer.TryRepair(ref oneplusPhone);

            Console.WriteLine("\nРезультат:");
            Console.WriteLine($"Сиоме {(xiaomiPhone.Broken ? "все еще сломан" : "уже починен")}");
            Console.WriteLine($"OnePlus {(oneplusPhone.Broken ? "все еще сломан" : "уже починен")}");

            Console.ReadKey();
        }

        interface IPhone
        {
            string Brand { get; }
            bool Broken { get; set; }
        }

        class XiaomiPhone : IPhone
        {
            public string Brand { get; }
            public bool Broken { get; set; }
            public XiaomiPhone(bool broken)
            {
                Brand = "Xiaomi";
                Broken = broken;
            }
        }
        class OneplusPhone : IPhone
        {
            public string Brand { get; }
            public bool Broken { get; set; }

            public OneplusPhone(bool broken)
            {
                Brand = "Oneplus";
                Broken = broken;
            }
        }

        interface IAuthorizedPhoneRepairer
        {
            IAuthorizedPhoneRepairer Successor { get; set; }
            void TryRepair(ref IPhone phone);
        }

        abstract class AuthorizedPhoneRepairer : IAuthorizedPhoneRepairer
        {
            public IAuthorizedPhoneRepairer Successor { get; set; }
            protected abstract string AuthorizedBrand { get; }

            public virtual void TryRepair(ref IPhone phone)
            {
                if (phone.Brand == AuthorizedBrand)
                    Repair(ref phone);
                else
                    Successor?.TryRepair(ref phone);
            }
            private void Repair(ref IPhone phone)
            {
                Console.WriteLine($"Чиним {phone.Brand}");
                phone.Broken = false;
            }
        }

        class IphoneRepairer : AuthorizedPhoneRepairer
        {
            protected override string AuthorizedBrand => "IPhone";
        }
        class SamsungRepairer : AuthorizedPhoneRepairer
        {
            protected override string AuthorizedBrand => "Samsung";
        }
        class XiaomiRepairer : AuthorizedPhoneRepairer
        {
            protected override string AuthorizedBrand => "Xiaomi";
        }
    }
}
