using System;
using System.Collections.Generic;

namespace Memento
{
    class Program
    {
        static void Main()
        {
            Player player = new Player(100, 20);
            GameSaver gameSaver = new GameSaver();

            player.Shoot();

            gameSaver.SaveData(player);

            player.Shoot();
            player.TakeDamage(20);

            Console.WriteLine(gameSaver.RestoreLastPlayerSave(ref player) ? "Data restored!" : "Can not restore data!");

            player.Shoot();
            player.TakeDamage(10);
            player.Shoot();

            Console.ReadKey();
        }
    }

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
    class GameSaver
    {
        private readonly Stack<PlayerMemento> _saves;

        public GameSaver()
        {
            _saves = new Stack<PlayerMemento>();
        }

        public void SaveData(Player player)
        {
            Console.WriteLine($"Saving... Now: {DateTime.Now}");
            _saves.Push(new PlayerMemento(player));
        }

        public bool RestoreLastPlayerSave(ref Player player)
        {
            if (_saves.Count < 1)
                return false;

            PlayerMemento playerMemento = _saves.Pop();
            Console.WriteLine($"Restoring save created at {playerMemento.SaveDate}...");
            player.Hp = playerMemento.Player.Hp;
            player.Ammo = playerMemento.Player.Ammo;
            return true;
        }
    }
}
