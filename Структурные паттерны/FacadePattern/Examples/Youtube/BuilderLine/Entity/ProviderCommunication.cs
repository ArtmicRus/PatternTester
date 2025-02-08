namespace FacadePattern.Examples.Youtube.BuilderLine.Entity
{
    internal class ProviderCommunication
    {
        public void Receive() => Console.WriteLine("Получение продукции от производителя");
        public void Payment() => Console.WriteLine("Оптала поставщику с удержанием комиссии за продажу продукции");
    }
}
