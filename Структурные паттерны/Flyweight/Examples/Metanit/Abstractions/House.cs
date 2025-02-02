namespace Flyweight.Examples.Metanit.Abstractions
{
    abstract class House
    {
        protected int stages; // количество этажей

        public abstract void Build(double longitude, double latitude);
    }
}
