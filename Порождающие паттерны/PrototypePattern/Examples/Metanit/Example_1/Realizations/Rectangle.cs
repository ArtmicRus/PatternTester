using PrototypePattern.Examples.Metanit.Example_1.Interfaces;

namespace PrototypePattern.Examples.Metanit.Example_1.Realizations
{
    class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public IFigure Clone()
        {
            return new Rectangle(width, height);
        }
        public void GetInfo()
        {
            Console.WriteLine("Прямоугольник длиной {0} и шириной {1}", height, width);
        }
    }
}
