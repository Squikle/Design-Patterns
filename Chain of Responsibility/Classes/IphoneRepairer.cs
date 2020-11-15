using Chain_of_Responsibility.Abstractions;

namespace Chain_of_Responsibility.Classes
{
    class IphoneRepairer : AuthorizedPhoneRepairer
    {
        protected override string AuthorizedBrand => "IPhone";
    }
}
