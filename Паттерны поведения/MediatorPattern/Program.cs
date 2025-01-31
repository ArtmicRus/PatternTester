using MediatorPattern.Examples.Metanit.Abstractions;
using MediatorPattern.Examples.Metanit.Realizations;

namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Паттерн Посредник (Mediator) представляет такой шаблон проектирования,
            // который обеспечивает взаимодействие множества объектов без необходимости ссылаться друг на друга.
            // Тем самым достигается слабосвязанность взаимодействующих объектов.

            ManagerMediator mediator = new ManagerMediator();
            Colleague customer = new CustomerColleague(mediator);
            Colleague programmer = new ProgrammerColleague(mediator);
            Colleague tester = new TesterColleague(mediator);
            mediator.Customer = customer;
            mediator.Programmer = programmer;
            mediator.Tester = tester;
            customer.Send("Есть заказ, надо сделать программу");
            programmer.Send("Программа готова, надо протестировать");
            tester.Send("Программа протестирована и готова к продаже");
        }
    }
}
