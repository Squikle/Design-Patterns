namespace Abstract_Factory.Interfaces
{
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
}
