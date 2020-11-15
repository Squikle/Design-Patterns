using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Classes
{
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
}
