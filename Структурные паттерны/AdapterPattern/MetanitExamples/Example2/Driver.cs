using AdapterPattern.MetanitExamples.Example2.Interfaces;

namespace AdapterPattern.MetanitExamples.Example2
{
    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}
