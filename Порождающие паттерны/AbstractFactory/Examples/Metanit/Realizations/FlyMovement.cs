using AbstractFactory.Examples.Metanit.Abstractions;

namespace AbstractFactory.Examples.Metanit.Realizations
{
    // движение полета
    class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Летим");
        }
    }
}
