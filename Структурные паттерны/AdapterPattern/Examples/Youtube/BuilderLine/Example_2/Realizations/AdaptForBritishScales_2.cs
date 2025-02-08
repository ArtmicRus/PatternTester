using AdapterPattern.Examples.Youtube.BuilderLine.Example_2.Interfaces;

namespace AdapterPattern.Examples.Youtube.BuilderLine.Example_2.Realizations
{
    internal class AdaptForBritishScales_2 : BritishScales_2, IScales_2
    {
        public AdaptForBritishScales_2(float cw) : base(cw) { }

        float IScales_2.GetWeight()
        {
            return base.GetWeight() * 0.453f;
        }

        void IScales_2.Adjust()
        {
            base.Adjust();
            Console.WriteLine(" в методе регулировки Adjust() адаптер");
        }
    }
}
