using TemplateMethod.Examples.Unknown.Impl;
using TemplateMethod.Examples.Youtube.BuilderLine.Abstractions;
using TemplateMethod.Examples.Youtube.BuilderLine.Realizations;

internal class Program
{
    private static void Main(string[] args)
    {
        // Шаблонный метод (Template Method) определяет общий алгоритм поведения подклассов,
        // позволяя им переопределить отдельные шаги этого алгоритма без изменения его структуры.

        #region

        School school = new School();
        University university = new University();

        school.Learn();
        university.Learn();

        #endregion

        #region BuilderLine

        Console.WriteLine();
        Console.WriteLine();

        Transmitter analogTransmitter = new AnalogTransmitter();
        analogTransmitter.ProcessStart();

        Console.WriteLine();

        Transmitter digitalTransmitter = new DigitTransmitter();
        digitalTransmitter.ProcessStart();

        #endregion
    }
}