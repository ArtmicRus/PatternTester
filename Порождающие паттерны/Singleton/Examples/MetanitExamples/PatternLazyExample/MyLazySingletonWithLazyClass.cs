namespace Singleton.Examples.MetanitExamples.PatternLazyExample
{
    internal class MyLazySingletonWithLazyClass
    {
        private static readonly Lazy<MyLazySingletonWithLazyClass> lazy =
            new Lazy<MyLazySingletonWithLazyClass>(() => new MyLazySingletonWithLazyClass());

        public string Name { get; private set; }

        private MyLazySingletonWithLazyClass()
        {
            Name = Guid.NewGuid().ToString();
        }

        public static MyLazySingletonWithLazyClass GetInstance()
        {
            return lazy.Value;
        }
    }
}
