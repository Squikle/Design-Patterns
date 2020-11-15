namespace Bridge
{
    abstract class Person : IPerson
    {
        public IDevice Device { get; set; }

        protected Person(IDevice device)
        {
            Device = device;
        }
        public void UseDevice()
        {
            Device.Start();
            DoWork();
            Device.Shutdown();
        }
        protected abstract void DoWork();
    }
}