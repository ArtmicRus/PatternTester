using OpenClosedPrinciple.MetanitExamples.Example1.Good.Interfaces;

namespace OpenClosedPrinciple.MetanitExamples.Example1.Good
{
    internal class GoodCook
    {
        public string Name { get; set; }

        public GoodCook(string name)
        {
            Name = name;
        }

        public void MakeDinner(IMeal meal)
        {
            meal.Make();
        }
    }
}
