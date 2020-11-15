using System;
using Abstract_Factory.Classes;

namespace Abstract_Factory
{
    class Program
    {
        static void Main()
        {
            Hero hero = new Hero(new SwordHeroFactory());
            hero.Hit();
            hero.Protect();

            hero = new Hero(new BowHeroFactory());
            hero.Hit();
            hero.Protect();
            
            // доп вариант через класс MyHeroFactory
            hero = new MyHeroFactory<SwordHeroFactory>().Create();
            hero.Hit();
            hero.Protect();

            hero = new MyHeroFactory<BowHeroFactory>().Create();
            hero.Hit();
            hero.Protect();

            Console.ReadKey();
        }
    }
}
