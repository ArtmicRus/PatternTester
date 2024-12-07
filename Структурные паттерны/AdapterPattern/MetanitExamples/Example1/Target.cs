namespace AdapterPattern.MetanitExamples.Example1
{
    /// <summary>
    /// Класс, к которому надо адаптировать другой класс  
    /// </summary>
    /// <remarks>
    /// Target: представляет объекты, которые используются клиентом
    /// </remarks>
    internal class Target
    {
        public virtual void Request()
        { }
    }
}
