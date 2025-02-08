using CompositePattern.Examples.Youtube.BuilderLine.Abstractions;

namespace CompositePattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class DropDownItem : Item
    {
        List<Item> children;

        public DropDownItem(string itemName) : base(itemName)
        {
            children = new List<Item>();
        }

        public override void Add(Item subItem)
        {
            subItem.SetOwner(_itemName);
            children.Add(subItem);
        }

        public override void Remove(Item subItem)
        {
            children.Remove(subItem);
        }

        public override void Display()
        {
            foreach (Item item in children) 
            {
                if (_ownerName != null)
                    Console.Write(_ownerName + _itemName);
                item.Display();
            }

            
        }
    }
}
