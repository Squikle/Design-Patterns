using System;

namespace Memento.Classes
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