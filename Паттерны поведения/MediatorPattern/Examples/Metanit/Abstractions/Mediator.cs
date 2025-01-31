namespace MediatorPattern.Examples.Metanit.Abstractions
{
    abstract class Mediator
    {
        public abstract void Send(string msg, Colleague colleague);
    }
}
