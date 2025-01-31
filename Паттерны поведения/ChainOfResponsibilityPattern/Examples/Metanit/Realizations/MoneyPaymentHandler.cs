using ChainOfResponsibilityPattern.Examples.Metanit.Abstractions;
using ChainOfResponsibilityPattern.Examples.Metanit.Entity;

namespace ChainOfResponsibilityPattern.Examples.Metanit.Realizations
{
    class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
                Console.WriteLine("Выполняем перевод через системы денежных переводов");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
