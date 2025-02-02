using ProxyPattern.Examples.Metanit.Entity;

namespace ProxyPattern.Examples.Metanit.Interfaces
{
    interface IBook : IDisposable
    {
        Page GetPage(int number);
    }
}
