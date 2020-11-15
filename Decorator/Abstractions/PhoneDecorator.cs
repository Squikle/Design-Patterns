using Decorator.Interfaces;

namespace Decorator.Abstractions
{
    abstract class PhoneDecorator : Phone
    {
        protected IPhone Phone;
        public override string Brand => Phone.Brand;
        protected PhoneDecorator(IPhone phone)
        {
            Phone = phone;
        }
    }
}
