using BridgePattern.Examples.Metanit.Abstractions;
using BridgePattern.Examples.Metanit.Interfaces;

namespace BridgePattern.Examples.Metanit.Realizations
{
    class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage lang)
            : base(lang)
        {
        }
        public override void EarnMoney()
        {
            Console.WriteLine("Получаем в конце месяца зарплату");
        }
    }
}
