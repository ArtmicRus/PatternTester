using TemplateMethod.Impl;

internal class Program
{
    private static void Main(string[] args)
    {
        // Шаблонный метод (Template Method) определяет общий алгоритм поведения подклассов,
        // позволяя им переопределить отдельные шаги этого алгоритма без изменения его структуры.

        School school = new School();
        University university = new University();

        school.Learn();
        university.Learn();

        Console.Read();
    }
}