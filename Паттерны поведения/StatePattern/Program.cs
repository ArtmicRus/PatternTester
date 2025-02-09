using StatePattern.Examples.Metanit.Entity;
using StatePattern.Examples.Metanit.Realizations;
using StatePattern.Examples.Youtube.BuilderLine.Entity;
using StatePattern.Examples.Youtube.BuilderLine.Realizations;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Состояние (State) - шаблон проектирования, который позволяет объекту изменять свое поведение
            // в зависимости от внутреннего состояния.

            #region

            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();

            #endregion

            #region BuilderLine

            TrafficLight trafficLight = new TrafficLight(new YellowState());

            trafficLight.NextState();
            trafficLight.NextState();

            trafficLight.PreviousState();
            trafficLight.PreviousState();
            trafficLight.PreviousState();

            #endregion
        }
    }
}
