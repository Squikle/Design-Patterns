using Decorator.Abstractions;

namespace Decorator.Classes
{
    class Oneplus8Phone : Phone
    {
        public override int Cost => 600;
        public override string Name => "Oneplus 8";
        public override string Brand => "Oneplus";
    }
}
