using AdapterPattern.Examples.Youtube.BuilderLine.Example_1.Interfaces;

namespace AdapterPattern.Examples.Youtube.BuilderLine.Example_1.Realizations
{
    internal class AdaptForBritishScales : IScales
    {

        private BritishScales _britishScales;

        public AdaptForBritishScales(BritishScales britishScales)
        {
            _britishScales = britishScales;
        }

        public float GetWeight()
        {
            return _britishScales.GetWeight() * 0.453f;
        }
    }
}
