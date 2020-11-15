namespace Bridge
{
    interface IPerson
    {
        IDevice Device { get; set; }
        void UseDevice();
    }
}