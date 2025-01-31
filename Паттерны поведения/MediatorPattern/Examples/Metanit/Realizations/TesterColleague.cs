using MediatorPattern.Examples.Metanit.Abstractions;

namespace MediatorPattern.Examples.Metanit.Realizations
{
    // класс тестера
    class TesterColleague : Colleague
    {
        public TesterColleague(Mediator mediator)
            : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение тестеру: " + message);
        }
    }
}
