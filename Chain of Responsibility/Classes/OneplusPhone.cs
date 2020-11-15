using Chain_of_Responsibility.Interfaces;

namespace Chain_of_Responsibility.Classes
{
    class OneplusPhone : IPhone
    {
        public string Brand { get; }
        public bool Broken { get; set; }

        public OneplusPhone(bool broken)
        {
            Brand = "Oneplus";
            Broken = broken;
        }
    }
}
