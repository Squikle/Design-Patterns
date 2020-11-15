namespace Mediator
{
    interface IMediator
    {
        void Send(string message, ITeammate teammate);
    }
}