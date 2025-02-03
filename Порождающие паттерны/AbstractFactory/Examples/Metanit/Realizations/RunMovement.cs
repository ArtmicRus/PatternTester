using AbstractFactory.Examples.Metanit.Abstractions;

namespace AbstractFactory.Examples.Metanit.Realizations
{
    // движение - бег
    class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}
