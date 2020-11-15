using System;
using Mediator.Classes;
using Mediator.Interfaces;

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
}
