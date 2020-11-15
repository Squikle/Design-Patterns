using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Classes
{
    class MyHeroFactory<T> where T : IHeroFactory, new()
    {
        public Hero Create()
        {
            T t = new T();
            return new Hero(t);
        }
    }
}
