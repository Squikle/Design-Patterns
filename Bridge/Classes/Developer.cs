namespace Bridge
{
    class Developer : Person
    {
        public Developer(IDevice device)
            : base(device) { }
        protected override void DoWork()
        {
            System.Console.WriteLine("Разработчик отлаживает программу");
        }
    }
}