using System;
using Chain_of_Responsibility.Classes;
using Chain_of_Responsibility.Interfaces;

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
    }
}
