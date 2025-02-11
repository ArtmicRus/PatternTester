﻿namespace CompositePattern.Examples.Youtube.BuilderLine.Abstractions
{
    internal abstract class Item
    {
        protected string _itemName;
        protected string _ownerName;

        protected Item(string itemName)
        {
            _itemName = itemName;
        }

        public void SetOwner(string ownerName)
        {
            _ownerName = ownerName;
        }

        public virtual void Add(Item subItem) { }
        public virtual void Remove(Item subItem) { }

        public abstract void Display();
    }
}
