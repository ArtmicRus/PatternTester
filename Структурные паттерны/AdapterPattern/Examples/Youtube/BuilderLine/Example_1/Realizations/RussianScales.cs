using AdapterPattern.Examples.Youtube.BuilderLine.Example_1.Interfaces;

namespace AdapterPattern.Examples.Youtube.BuilderLine.Example_1.Realizations
{
    internal class RussianScales : IScales
    {
        private float _currentWeight;

        public RussianScales(float currentWeight)
        {
            _currentWeight = currentWeight;
        }

        public float GetWeight()
        {
            return _currentWeight;
        }
    }
}
