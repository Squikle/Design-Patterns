using Patterns.Interfaces;

namespace Patterns.Classes
{
    class VanMechanic : IMechanic
    {
        public IVehicle BuildVehicle()
        {
            return new Van();
        }
    }
}