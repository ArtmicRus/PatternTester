using AdapterPattern.MetanitExamples.Example2.Interfaces;

namespace AdapterPattern.MetanitExamples.Example2.Adapter
{
    /// <summary>
    /// Адаптер от Camel к ITransport
    /// </summary>
    class CamelToTransportAdapter : ITransport
    {
        Camel camel;
        public CamelToTransportAdapter(Camel c)
        {
            camel = c;
        }

        public void Drive()
        {
            camel.Move();
        }
    }
}
