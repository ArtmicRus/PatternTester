namespace Singleton.Examples.MetanitExamples.PatternDefaultExample
{
    internal class Singleton
    {
        private static Singleton instance;

        private Singleton()
        { }

        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}
