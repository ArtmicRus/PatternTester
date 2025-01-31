using ChainOfResponsibilityPattern.Examples.Metanit.Abstractions;
using ChainOfResponsibilityPattern.Examples.Metanit.Entity;

namespace ChainOfResponsibilityPattern.Examples.Metanit.Realizations
{
    class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
                Console.WriteLine("Выполняем банковский перевод");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
