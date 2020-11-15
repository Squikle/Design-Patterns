namespace Patterns
{
    class VanMechanic : IMechanic
    {
        public IVehicle BuildVehicle()
        {
            return new Van();
        }
    }
}