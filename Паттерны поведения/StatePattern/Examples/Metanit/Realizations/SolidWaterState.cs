using StatePattern.Examples.Metanit.Entity;
using StatePattern.Examples.Metanit.Interfaces;

namespace StatePattern.Examples.Metanit.Realizations
{
    class SolidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем лед в жидкость");
            water.State = new LiquidWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Продолжаем заморозку льда");
        }
    }
}
