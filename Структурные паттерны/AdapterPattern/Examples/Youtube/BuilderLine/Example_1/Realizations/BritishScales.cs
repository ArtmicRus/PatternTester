using AdapterPattern.Examples.Youtube.BuilderLine.Example_1.Interfaces;

namespace AdapterPattern.Examples.Youtube.BuilderLine.Example_1.Realizations
{
    internal class BritishScales : IScales
    {
        private float _currentWeight;

        public BritishScales(float currentWeight)
        {
            _currentWeight = currentWeight;
        }

        public float GetWeight()
        {
            return _currentWeight;
        }
    }
}
