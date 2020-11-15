namespace Abstract_Factory.Interfaces
{
    interface IHeroFactory
    {
        IWeapon CreateWeapon();
        IArmor CreateArmor();
    }
}
