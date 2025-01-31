using ChainOfResponsibilityPattern.Examples.Metanit.Abstractions;
using ChainOfResponsibilityPattern.Examples.Metanit.Entity;

namespace ChainOfResponsibilityPattern.Examples.Metanit.Realizations
{
    class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
                Console.WriteLine("Выполняем перевод через PayPal");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
