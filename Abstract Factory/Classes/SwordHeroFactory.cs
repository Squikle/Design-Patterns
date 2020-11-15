using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Classes
{
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
}
