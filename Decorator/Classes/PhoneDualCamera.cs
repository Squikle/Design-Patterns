using Decorator.Abstractions;
using Decorator.Interfaces;

namespace Decorator.Classes
{
    class PhoneDualCamera : PhoneDecorator
    {
        public override int Cost
            => this.Phone.Cost + 100;
        public override string Name => this.Phone.Name + " Dual Camera";
        public PhoneDualCamera(IPhone phone) : base(phone) { }
    }
}
