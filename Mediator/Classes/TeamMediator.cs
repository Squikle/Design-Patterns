namespace Mediator
{
    class TeamMediator : IMediator
    {
        public ITeammate Support;
        public ITeammate Tank;
        public ITeammate DamageDealer;

        public TeamMediator(ITeammate support, ITeammate tank, ITeammate damageDealer)
        {
            Support = support;
            Tank = tank;
            DamageDealer = damageDealer;
        }
        public void Send(string message, ITeammate sender)
        {
            string messageToSend = $"[{sender.Class}]: " + message;
            if (sender == Support)
                DamageDealer.Notify(messageToSend);
            else if (sender == Tank)
            {
                DamageDealer.Notify(messageToSend);
                Support.Notify(messageToSend);
            }
            else if (sender == DamageDealer)
            {
                Tank.Notify(messageToSend);
            }
        }
    }
}