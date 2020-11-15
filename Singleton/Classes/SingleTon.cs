using System;

namespace Singleton.Classes
{
    class SingleTon
    {
        public string Name { get; private set; }
        public DateTime CreatedAt { get; private set; }

        private static SingleTon _instance;
        private static Object _lock = new object();
        public static SingleTon Create(string name)
        {
            if (_instance != null)
                throw new Exception("already exist");
            lock (_lock)
            {
                _instance = new SingleTon { Name = name, CreatedAt = DateTime.Now };
                return _instance;
            }
        }

        public static SingleTon GetInstance()
        {
            return _instance;
        }
    }
}
