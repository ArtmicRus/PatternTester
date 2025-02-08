using AdapterPattern.Examples.Youtube.BuilderLine.Example_2.Interfaces;

namespace AdapterPattern.Examples.Youtube.BuilderLine.Example_2.Realizations
{
    internal class RussianScales_2 : IScales_2
    {
        private float _currentWeight;

        public RussianScales_2(float currentWeight)
        {
            _currentWeight = currentWeight;
        }

        public void Adjust()
        {
            Console.WriteLine("Регулировка российских весов");
        }

        public float GetWeight()
        {
            return _currentWeight;
        }
    }
}
