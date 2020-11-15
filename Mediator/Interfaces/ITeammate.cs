namespace Mediator.Interfaces
{
    interface ITeammate
    {
        void Notify(string message);
        IMediator Mediator { get; set; }
        string Class { get; }
        void Send(string message);
    }
}