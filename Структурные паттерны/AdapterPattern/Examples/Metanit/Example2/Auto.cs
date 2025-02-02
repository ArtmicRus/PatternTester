using AdapterPattern.Examples.Metanit.Example2.Interfaces;

namespace AdapterPattern.Examples.Metanit.Example2
{
    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }
}
