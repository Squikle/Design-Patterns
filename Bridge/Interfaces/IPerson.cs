namespace Bridge.Interfaces
{
    interface IPerson
    {
        IDevice Device { get; set; }
        void UseDevice();
    }
}