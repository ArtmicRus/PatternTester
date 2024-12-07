namespace AdapterPattern.MetanitExamples.Example1
{
    /// <summary>
    /// Client: использует объекты Target для реализации своих задач
    /// </summary>
    internal class Client
    {
        public void Request(Target target)
        {
            target.Request();
        }
    }
}
