using System;
using Composite.Classes;

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
}
