using Flyweight.Examples.Youtube.BuilderLine.Structures;
using System.Collections;

namespace Flyweight.Examples.Youtube.BuilderLine.Entity
{
    internal class FlyweightFactory
    {
        private Hashtable flyweight;
        private string GetKey(Shared shared) => shared.Company + "_" + shared.Position;

        public FlyweightFactory(List<Shared> shareds)
        {
            flyweight = new Hashtable();
            foreach (var shared in shareds)
            {
                flyweight.Add(GetKey(shared), new Flyweight(shared));
            }
        }

        public Flyweight GetFlyweight(Shared shared)
        {
            string key = GetKey(shared);
            if (!flyweight.Contains(key))
            {
                Console.WriteLine("Фабрика легковесов: Общий объект по ключу " + key + " не найден. Создаём новый.");
                flyweight.Add(key, new Flyweight(shared));
            }
            else
            {
                Console.WriteLine("Фабрика легковесов: извлекаем данные из имеющихся записей по ключу " + key + ".");
            }
            return (Flyweight)flyweight[key];
        }

        public void ListFlyweight()
        {
            int count = flyweight.Count;
            Console.WriteLine("Фабрика легковесов: Всего " + count + " записей:");
            foreach (Flyweight pair in flyweight.Values)
            {
                Console.WriteLine(pair.GetData());
            }
        }
    }
}
