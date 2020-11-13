using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(new GamingConsole());
            player.Play();

            player.GamingDevice = new GamingPC();
            player.Play();

            Console.ReadKey();
        }

        class Player
        {
            public IPlayable GamingDevice { get; set; }

            public Player(IPlayable gamingDevice)
            {
                GamingDevice = gamingDevice;
            }

            public void Play()
            {
                GamingDevice.Enable();
                GamingDevice.Play();
                GamingDevice.Disable();
            }
        }
        interface IPlayable
        {
            void Enable();
            void Disable();
            void Play();
        }
        abstract class Playable : IPlayable
        {
            public void Enable()
            {
                Console.WriteLine("Запуск устройства");
            }
            public void Disable()
            {
                Console.WriteLine("Выключение устройства");
            }
            public abstract void Play();
        }

        class GamingPC : Playable
        {
            public override void Play()
            {
                Console.WriteLine("Игра на игровом компьютере");
            }
        }
        class GamingConsole : Playable
        {
            public override void Play()
            {
                Console.WriteLine("Игра на игровой консоли");
            }
        }
    }
}
