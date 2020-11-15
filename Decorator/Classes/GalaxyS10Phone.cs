using Decorator.Abstractions;

namespace Decorator.Classes
{
    class GalaxyS10Phone : Phone
    {
        public override int Cost => 700;
        public override string Name => "Galaxy S10";
        public override string Brand => "Samsung";

    }
}
