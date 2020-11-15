using Decorator.Abstractions;
using Decorator.Interfaces;

namespace Decorator.Classes
{
    class Phone5G : PhoneDecorator
    {
        public override int Cost
            => this.Phone.Cost + 80;

        public override string Name => this.Phone.Name + " 5g";
        public Phone5G(IPhone phone) : base(phone) { }
    }
}
