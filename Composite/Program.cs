using System;
using System.Collections.Generic;
using System.Text;
namespace Composite
{
    class Program
    {
        static void Main()
        {
            Branch rootBranch = new Branch("root");

            Branch firstBranch = new Branch("firstBranch");
            rootBranch.Add(firstBranch);

            Leaf firstLeaf = new Leaf("firstLeaf");
            Leaf secondLeaf = new Leaf("SecondLeaf");
            Branch secondBranch = new Branch("secondBranch");
            firstBranch.Add(firstLeaf);
            firstBranch.Add(secondLeaf);
            firstBranch.Add(secondBranch);

            Console.WriteLine(rootBranch + "\n");
            Console.WriteLine(firstBranch + "\n");
            Console.WriteLine(firstLeaf + "\n");

            firstBranch.Remove(firstLeaf);
            Console.WriteLine(firstBranch);

            Console.ReadKey();
        }
    }

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

    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        { }
    }
}
