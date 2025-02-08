using OOP.Examples.Youtube.Ulbi_TV.Polymorphism;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new("Антон", "Иванов", 12);
            Employee employee = new("Артём", "Терёхин", 14, "2353", "3121262", "snulsus");
            Developer developer = new("Ваня", "Петров", 13, "235125", "31262", "snuls", "middle", "C++");

            //person.Greatings();
            //employee.Greatings();
            //developer.Greatings();

            //List<Person> list = [person, employee, developer];
            //foreach (var item in list)
            //{
            //    item.Greatings();
            //}

            Person[] people = [person, employee, developer];
            foreach (var item in people)
            {
                Console.WriteLine(item.GetType());
                item.Greatings();
            }
        }
    }
}
