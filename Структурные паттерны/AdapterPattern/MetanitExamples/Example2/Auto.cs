using AdapterPattern.MetanitExamples.Example2.Interfaces;

namespace AdapterPattern.MetanitExamples.Example2
{
    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }
}
