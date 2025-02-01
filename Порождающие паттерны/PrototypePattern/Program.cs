using PrototypePattern.Examples.Metanit.Example_1.Interfaces;
using PrototypePattern.Examples.Metanit.Example_1.Realizations;

namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Паттерн Прототип (Prototype) позволяет создавать объекты на основе уже ранее созданных объектов-прототипов.
            // То есть по сути данный паттерн предлагает технику клонирования объектов.

            #region Example 1

            IFigure figure = new Rectangle(30, 40);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle(30);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            #endregion

            #region Example 2



            #endregion

        }
    }
}
