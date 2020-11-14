using System;

namespace Mediator
{
    class Program
    {
        static void Main()
        {
            ITeammate support = new Support();
            ITeammate tank = new Tank();
            ITeammate damageDealer = new DamageDealer();
            IMediator mediator = new TeamMediator(support, tank, damageDealer);
            support.Mediator = mediator;
            tank.Mediator = mediator;
            damageDealer.Mediator = mediator;
            tank.Send("Давайте пушить, я прикрываю");
            support.Send("Аккуратнее, у меня хил на кд");
            damageDealer.Send("Прикрой, у меня кд");

            Console.ReadKey();
        }
    }

    interface IMediator
    {
        void Send(string message, ITeammate teammate);
    }

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
    interface ITeammate
    {
        void Notify(string message);
        IMediator Mediator { get; set; }
        string Class { get; }
        void Send(string message);
    }

    abstract class Teammate : ITeammate
    {
        public abstract string Class { get; }
        public IMediator Mediator { get; set; }
        public virtual void Send(string message)
        {
            Mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine($"Сообщение для [{Class}]: " + message);
        }
    }

    class Support : Teammate
    {
        public override string Class => "Саппорт";
    }
    class Tank : Teammate
    {
        public override string Class => "Танк";
    }
    class DamageDealer : Teammate
    {
        public override string Class => "Дамагер";
    }
}
