using BridgePattern.Examples.Metanit.Abstractions;
using BridgePattern.Examples.Metanit.Interfaces;

namespace BridgePattern.Examples.Metanit.Realizations
{
    class FreelanceProgrammer : Programmer
    {
        public FreelanceProgrammer(ILanguage lang) : base(lang)
        {
        }
        public override void EarnMoney()
        {
            Console.WriteLine("Получаем оплату за выполненный заказ");
        }
    }
}
