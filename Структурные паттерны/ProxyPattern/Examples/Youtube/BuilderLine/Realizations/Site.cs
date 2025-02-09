using ProxyPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace ProxyPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class Site : ISite // Есть системный интерфейс в System.ComponentModel (или что то похожее)
    {
        public string GetPage(int pageIndex)
        {
            return "Это страницу " + pageIndex;
        }
    }
}
