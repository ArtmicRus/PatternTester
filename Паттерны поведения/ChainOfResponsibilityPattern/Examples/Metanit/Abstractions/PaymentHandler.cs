using ChainOfResponsibilityPattern.Examples.Metanit.Entity;

namespace ChainOfResponsibilityPattern.Examples.Metanit.Abstractions
{
    abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }
}
