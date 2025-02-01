using PrototypePattern.Examples.Metanit.Interfaces;
using PrototypePattern.Examples.Metanit.Realizations;

namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Паттерн Прототип (Prototype) позволяет создавать объекты на основе уже ранее созданных объектов-прототипов.
            // То есть по сути данный паттерн предлагает технику клонирования объектов.

            IFigure figure = new Rectangle(30, 40);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle(30);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
        }
    }
}
