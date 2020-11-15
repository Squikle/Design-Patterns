using System;

namespace Memento.Classes
{
    class Player
    {
        public int Hp;
        public int Ammo;

        public Player(int defaultHp, int defaultAmmo)
        {
            Hp = defaultHp;
            Ammo = defaultAmmo;
        }
        public void Shoot()
        {
            Ammo--;
            Console.WriteLine($"Pew! Left {Ammo}ammo");
        }
        public void TakeDamage(int damage)
        {
            Hp-=damage;
            Console.WriteLine($"Ouch! Left {Hp}hp");
        }
    }
}