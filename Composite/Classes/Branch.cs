using System.Collections.Generic;
using System.Text;
using Composite.Abstractions;

namespace Composite.Classes
{
    class Branch : Component
    {
        private IList<Component> _components;

        public Branch(string name) : base(name)
        {
            _components = new List<Component>();
        }
        public void Add(Component component)
        {
            _components.Add(component);
        }
        public void Remove(Component component)
        {
            _components.Remove(component);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder($"Ветка: {Name}\nКомпоненты:");
            foreach (var component in _components)
            {
                output.Append($" {component.Name}");
            }

            return output.ToString();
        }
    }
}