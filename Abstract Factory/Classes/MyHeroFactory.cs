namespace Abstract_Factory.Interfaces
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
