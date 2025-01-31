using StatePattern.Examples.Metanit.Entity;

namespace StatePattern.Examples.Metanit.Interfaces
{
    interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}
