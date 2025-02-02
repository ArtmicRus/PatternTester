using BridgePattern.Examples.Metanit.Abstractions;
using BridgePattern.Examples.Metanit.Realizations;

namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Мост (Bridge) - структурный шаблон проектирования, который позволяет отделить абстракцию
            // от реализации таким образом, чтобы и абстракцию, и реализацию можно было изменять
            // независимо друг от друга.

            // Даже если мы отделим абстракцию от конкретных реализаций, то у нас все равно
            // все наследуемые классы будут жестко привязаны к интерфейсу, определяемому в базовом абстрактном классе.
            // Для преодоления жестких связей и служит паттерн Мост.

            // создаем нового программиста, он работает с с++
            Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();
            // пришел новый заказ, но теперь нужен c#
            freelancer.Language = new CSharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();
        }
    }
}
