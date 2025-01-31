using MediatorPattern.Examples.Metanit.Abstractions;

namespace MediatorPattern.Examples.Metanit.Realizations
{
    // класс заказчика
    class CustomerColleague : Colleague
    {
        public CustomerColleague(Mediator mediator)
            : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение заказчику: " + message);
        }
    }
}
