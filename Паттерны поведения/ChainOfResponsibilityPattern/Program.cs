using ChainOfResponsibilityPattern.Examples.Metanit.Abstractions;
using ChainOfResponsibilityPattern.Examples.Metanit.Entity;
using ChainOfResponsibilityPattern.Examples.Metanit.Realizations;

namespace ChainOfResponsibilityPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Цепочка Обязанностей (Chain of responsibility) - поведенческий шаблон проектирования,
            // который позволяет избежать жесткой привязки отправителя запроса к получателю.
            // Все возможные обработчики запроса образуют цепочку, а сам запрос перемещается по этой цепочке.
            // Каждый объект в этой цепочке при получении запроса выбирает, либо закончить обработку запроса,
            // либо передать запрос на обработку следующему по цепочке объекту.

            Receiver receiver = new Receiver(false, true, true);

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();
            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHadler;

            bankPaymentHandler.Handle(receiver);
        }
    }
}
