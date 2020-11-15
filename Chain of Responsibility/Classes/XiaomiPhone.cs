using Chain_of_Responsibility.Interfaces;

namespace Chain_of_Responsibility.Classes
{
    class XiaomiPhone : IPhone
    {
        public string Brand { get; }
        public bool Broken { get; set; }
        public XiaomiPhone(bool broken)
        {
            Brand = "Xiaomi";
            Broken = broken;
        }
    }
}
