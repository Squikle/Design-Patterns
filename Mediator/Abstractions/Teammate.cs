using System;
using Mediator.Interfaces;

namespace Mediator.Abstractions
{
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
}