using ChainOfResponsibilityPattern.Examples.Metanit.Abstractions;
using ChainOfResponsibilityPattern.Examples.Metanit.Entity;
using ChainOfResponsibilityPattern.Examples.Metanit.Realizations;
using ChainOfResponsibilityPattern.Examples.Youtube.BuilderLine.Realizations;
using ChainOfResponsibilityPattern.Examples.Youtube.BuilderLine.StaticHelper;

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


            #region Metanit

            Receiver receiver = new Receiver(false, true, true);

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();
            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHadler;

            bankPaymentHandler.Handle(receiver);

            #endregion

            #region BuilderLine

            Designer designer = new Designer();
            Carpenter carpenter = new Carpenter();
            FinishingWorker finishWorker = new FinishingWorker();

            designer.SetNextWorker(carpenter).SetNextWorker(finishWorker);

            GiveCommand.GiveCommander(designer, "спроектировать дом");
            GiveCommand.GiveCommander(designer, "класть кирпич");
            GiveCommand.GiveCommander(designer, "клеить обои");

            GiveCommand.GiveCommander(designer, "провести проводку");

            #endregion
        }
    }
}
