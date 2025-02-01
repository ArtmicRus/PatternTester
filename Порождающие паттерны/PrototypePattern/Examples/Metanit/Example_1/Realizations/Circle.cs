using PrototypePattern.Examples.Metanit.Example_1.Interfaces;

namespace PrototypePattern.Examples.Metanit.Example_1.Realizations
{

    class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return new Circle(radius);
        }
        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом {0}", radius);
        }
    }
}
