using AdapterPattern.Examples.Youtube.BuilderLine.Example_2.Interfaces;

namespace AdapterPattern.Examples.Youtube.BuilderLine.Example_2.Realizations
{
    internal class BritishScales_2 : IScales_2
    {
        private float _currentWeight;

        public BritishScales_2(float currentWeight)
        {
            _currentWeight = currentWeight;
        }

        public void Adjust()
        {
            Console.Write("Регулировка британских весов");
        }

        public float GetWeight()
        {
            return _currentWeight;
        }
    }
}
