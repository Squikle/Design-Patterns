using System;
using Facade.Interfaces;

namespace Facade.Classes
{
    class Memory120Gb : IMemory
    {
        public void Save()
        {
            Console.WriteLine("Save Data");
        }

        public void Load()
        {
            Console.WriteLine("Load Data");
        }
    }
}