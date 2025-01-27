using AdapterPattern.MetanitExamples.Example2.Interfaces;

namespace AdapterPattern.MetanitExamples.Example2
{
    class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Верблюд идет по пескам пустыни");
        }
    }
}
