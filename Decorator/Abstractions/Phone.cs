using Decorator.Interfaces;

namespace Decorator.Abstractions
{
    abstract class Phone : IPhone
    {
        public abstract string Name { get; }
        public abstract string Brand { get; }
        public abstract int Cost { get; }
    }
}
