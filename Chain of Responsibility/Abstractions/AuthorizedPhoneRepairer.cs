using System;
using Chain_of_Responsibility.Interfaces;

namespace Chain_of_Responsibility.Abstractions
{
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
}
