using Chain_of_Responsibility.Abstractions;

namespace Chain_of_Responsibility.Classes
{
    class XiaomiRepairer : AuthorizedPhoneRepairer
    {
        protected override string AuthorizedBrand => "Xiaomi";
    }
}
