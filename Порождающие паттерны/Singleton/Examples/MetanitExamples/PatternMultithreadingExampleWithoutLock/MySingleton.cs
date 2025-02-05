namespace Singleton.Examples.MetanitExamples.PatternMultithreadingExampleWithoutLock
{
    internal class MySingleton
    {
        private static readonly MySingleton instance = new MySingleton();

        public string Date { get; private set; }

        private MySingleton()
        {
            Date = DateTime.Now.TimeOfDay.ToString();
        }

        public static MySingleton GetInstance()
        {
            return instance;
        }
    }
}
