namespace Chain_of_Responsibility.Interfaces
{
    interface IAuthorizedPhoneRepairer
    {
        IAuthorizedPhoneRepairer Successor { get; set; }
        void TryRepair(ref IPhone phone);
    }
}
