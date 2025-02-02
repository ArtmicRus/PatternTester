using BridgePattern.Examples.Metanit.Interfaces;

namespace BridgePattern.Examples.Metanit.Realizations
{
    class CPPLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("С помощью компилятора C++ компилируем программу в бинарный код");
        }

        public void Execute()
        {
            Console.WriteLine("Запускаем исполняемый файл программы");
        }
    }
}
