using Template_Method.Interfaces;

namespace Template_Method.Classes
{
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
}