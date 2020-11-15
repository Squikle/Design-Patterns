namespace Patterns
{
    class CarMechanic : IMechanic
    {
        public IVehicle BuildVehicle()
        {
            return new Car();
        }
    }
}