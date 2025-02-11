﻿using MediatorPattern.Examples.Metanit.Abstractions;

namespace MediatorPattern.Examples.Metanit.Realizations
{
    // класс программиста
    class ProgrammerColleague : Colleague
    {
        public ProgrammerColleague(Mediator mediator)
            : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение программисту: " + message);
        }
    }
}
