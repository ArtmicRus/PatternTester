using Flyweight.Examples.Youtube.BuilderLine.Structures;

namespace Flyweight.Examples.Youtube.BuilderLine.Entity
{
    internal class Flyweight
    {
        private Shared _shared;

        public Flyweight(Shared shared)
        {
            _shared = shared;
        }

        public void Procces (Unique unique)
        {
            Console.WriteLine("Отображаем новые данные: Общее " + _shared.Company + "_" + _shared.Position + " и уникальное - " + unique.Name + "_" + unique.Passport);
        }

        public string GetData()
        {
            return _shared.Company + "_" + _shared.Position;
        }
    }
}
