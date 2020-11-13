using System;

namespace Template_Method
{
    class Program
    {
        static void Main()
        {
            Player player = new Player(new GamingConsole());
            player.Play();

            player.GamingDevice = new GamingPc();
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

        class GamingPc : Playable
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
