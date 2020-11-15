using System;

namespace Memento
{
    class PlayerMemento
    {
        public Player Player;
        public DateTime SaveDate;

        public PlayerMemento(Player player)
        {
            Player = new Player(player.Hp, player.Ammo);
            SaveDate = DateTime.Now;
        }
    }
}