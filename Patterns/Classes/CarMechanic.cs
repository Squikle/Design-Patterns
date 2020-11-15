using Patterns.Interfaces;

namespace Patterns.Classes
{
    class CarMechanic : IMechanic
    {
        public IVehicle BuildVehicle()
        {
            return new Car();
        }
    }
}