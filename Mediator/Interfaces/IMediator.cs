namespace Mediator.Interfaces
{
    interface IMediator
    {
        void Send(string message, ITeammate teammate);
    }
}