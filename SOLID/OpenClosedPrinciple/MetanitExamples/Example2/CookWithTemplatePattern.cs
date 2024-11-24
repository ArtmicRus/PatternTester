using OpenClosedPrinciple.MetanitExamples.Example2.Meals;

namespace OpenClosedPrinciple.MetanitExamples.Example2
{
    internal class CookWithTemplatePattern
    {
        public string Name { get; set; }

        public CookWithTemplatePattern(string name)
        {
            this.Name = name;
        }

        public void MakeDinner(MealBase[] menu)
        {
            foreach (MealBase meal in menu)
                meal.Make();
        }
    }
}
