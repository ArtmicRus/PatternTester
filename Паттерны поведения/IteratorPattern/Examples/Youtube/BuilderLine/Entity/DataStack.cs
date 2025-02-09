namespace IteratorPattern.Examples.Youtube.BuilderLine.Entity
{
    internal class DataStack
    {
        private int[] items = new int[10];
        private int length;

        public DataStack()
        {
            length = -1;
        }
        public DataStack(DataStack myStack)
        {
            this.items = myStack.items;
            this.length = myStack.length;
        }

        public int[] Items { get => items; }
        public int Length { get => length; }

        public void Push (int item)
        {
            items[++length] = item;
        }

        public int Pop()
        {
            return items[length--];
        }

        public static bool operator ==(DataStack myStack1, DataStack myStack2)
        {
            StackIterator it1 = new StackIterator(myStack1);
            StackIterator it2 = new StackIterator(myStack2);

            while (it1.IsEnd() || it2.IsEnd())
            {
                if (it1.Get() != it2.Get()) break;
                it1++;
                it2++;
            }

            return !it1.IsEnd() && !it2.IsEnd();
        }

        public static bool operator !=(DataStack myStack1, DataStack myStack2)
        {
            StackIterator it1 = new StackIterator(myStack1);
            StackIterator it2 = new StackIterator(myStack2);

            while (it1.IsEnd() || it2.IsEnd())
            {
                if (it1.Get() != it2.Get()) break;
                it1++;
                it2++;
            }

            return !(!it1.IsEnd() && !it2.IsEnd());
        }
    }
}
