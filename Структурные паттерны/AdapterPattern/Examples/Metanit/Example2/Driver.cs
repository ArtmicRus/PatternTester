using AdapterPattern.Examples.Metanit.Example2.Interfaces;

namespace AdapterPattern.Examples.Metanit.Example2
{
    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}
