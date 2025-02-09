using Flyweight.Examples.Youtube.BuilderLine.Entity;

namespace Flyweight.Examples.Youtube.BuilderLine.HelpMethods
{
    internal class FlyweightHelper
    {
        public static void AddSpecialistDatabase(FlyweightFactory ff, string company, string position, string name, string passport)
        {
            Console.WriteLine();
            Entity.Flyweight flyweight = ff.GetFlyweight(new Structures.Shared(company,position));
            flyweight.Procces(new Structures.Unique(name, passport));
        }
    }   
}
