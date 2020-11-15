using System;
using System.Collections.Generic;

namespace Memento.Classes
{
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