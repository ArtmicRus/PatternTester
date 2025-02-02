namespace AdapterPattern.Examples.Metanit.Example1
{
    /// <summary>
    /// Адаптер
    /// </summary>
    /// <remarks>
    /// Adapter: собственно адаптер, который позволяет работать с объектами Adaptee как с объектами Target.
    /// </remarks>
    internal class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
