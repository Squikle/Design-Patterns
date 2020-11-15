using System;
using Memento.Classes;

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
}
