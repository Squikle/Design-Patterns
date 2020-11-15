using Chain_of_Responsibility.Abstractions;

namespace Chain_of_Responsibility.Classes
{
    class SamsungRepairer : AuthorizedPhoneRepairer
    {
        protected override string AuthorizedBrand => "Samsung";
    }
}
