using System;

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

        interface IWeapon
        {
            void Hit();
        }

        class Sword : IWeapon
        {
            public void Hit()
            {
                Console.WriteLine("Sword Hit!");
            }
        }
        class Bow : IWeapon
        {
            public void Hit()
            {
                Console.WriteLine("Bow Hit!");
            }
        }
        interface IArmor
        {
            void Protect();
        }

        class IronArmor : IArmor
        {
            public void Protect()
            {
                Console.WriteLine("Iron Armor Protect!");
            }
        }

        class PlasticArmor : IArmor
        {
            public void Protect()
            {
                Console.WriteLine("Plastic Armor Protect!");
            }
        }
        interface IHeroFactory
        {
            IWeapon CreateWeapon();
            IArmor CreateArmor();
        }

        class BowHeroFactory : IHeroFactory
        {
            public IWeapon CreateWeapon()
            {
                return new Bow();
            }
            public IArmor CreateArmor()
            {
                return new PlasticArmor();
            }
        }

        class SwordHeroFactory : IHeroFactory
        {
            public IWeapon CreateWeapon()
            {
                return new Sword();
            }
            public IArmor CreateArmor()
            {
                return new IronArmor();
            }
        }

        class Hero
        {
            private readonly IWeapon _weapon;
            private readonly IArmor _armor;
            public Hero(IHeroFactory heroFactory)
            {
                _weapon = heroFactory.CreateWeapon();
                _armor = heroFactory.CreateArmor();
            }

            public void Hit()
            {
                _weapon.Hit();
            }

            public void Protect()
            {
                _armor.Protect();
            }
        }

        class MyHeroFactory<T> where T : IHeroFactory, new()
        {
            public Hero Create()
            {
                T t = new T();
                return new Hero(t);
            }
        }
    }
}
