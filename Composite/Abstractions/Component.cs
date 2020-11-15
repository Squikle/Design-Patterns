namespace Composite.Abstractions
{
    abstract class Component
    {
        public string Name;

        protected Component(string name)
        {
            Name = name;
        }

        public override string ToString()
            => Name;
    }
}