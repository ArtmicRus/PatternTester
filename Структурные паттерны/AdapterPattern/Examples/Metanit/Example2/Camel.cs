using AdapterPattern.Examples.Metanit.Example2.Interfaces;

namespace AdapterPattern.Examples.Metanit.Example2
{
    class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Верблюд идет по пескам пустыни");
        }
    }
}
