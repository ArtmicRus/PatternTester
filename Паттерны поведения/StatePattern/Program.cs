using StatePattern.Examples.Metanit.Entity;
using StatePattern.Examples.Metanit.Realizations;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Состояние (State) - шаблон проектирования, который позволяет объекту изменять свое поведение
            // в зависимости от внутреннего состояния.

            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();
        }
    }
}
