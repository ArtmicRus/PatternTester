using OpenClosedPrinciple.MetanitExamples.Example1.Bad;
using OpenClosedPrinciple.MetanitExamples.Example1.Good;
using OpenClosedPrinciple.MetanitExamples.Example1.Good.InterfacesImpl;
using OpenClosedPrinciple.MetanitExamples.Example2;
using OpenClosedPrinciple.MetanitExamples.Example2.Meals;

internal class Program
{
    private static void Main(string[] args)
    {
        // Принцип открытости/закрытости (Open/Closed Principle) можно сформулировать так:
        // Сущности программы должны быть открыты для расширения, но закрыты для изменения.

        // Второе определение: Класс должен быть открыт для ДОБАВЛЕНИЯ нового функционала и 
        // закрыт для МОДИФИКАЦИИ существующего функционала (чтобы не ломали старый код)

        // Суть этого принципа состоит в том, что система должна быть построена таким образом,
        // что все ее последующие изменения должны быть реализованы с помощью добавления нового кода,
        // а не изменения уже существующего.

        #region Плохой пример без использований паттернов

        BadCook bob = new BadCook("Bob");
        bob.MakeDinner();

        #endregion

        #region С паттерном Стратегия

        GoodCook newBob = new GoodCook("Bob");
        newBob.MakeDinner(new PotatoMeal());
        Console.WriteLine();
        newBob.MakeDinner(new SaladMeal());

        #endregion

        #region С Шаблонным паттерном

        // В данном случае расширение класса опять же производится за счет наследования классов,
        // которые определяют требуемый функционал.

        MealBase[] menu = new MealBase[] { new PotatoTemplateMeal(), new SaladTemplateMeal() };

        CookWithTemplatePattern bob3 = new CookWithTemplatePattern("Bob");
        bob3.MakeDinner(menu);

        #endregion
    }
}