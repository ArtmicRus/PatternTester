using CompositePattern.Examples.Youtube.BuilderLine.Abstractions;

namespace CompositePattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class ClicableItem : Item
    {
        public ClicableItem(string itemName) : base(itemName)
        {
        }

        public override void Add(Item subItem)
        {
            throw new Exception();
        }

        public override void Remove(Item subItem)
        {
            throw new Exception();
        }
        public override void Display()
        {
            Console.WriteLine(_itemName);
        }
    }
}
