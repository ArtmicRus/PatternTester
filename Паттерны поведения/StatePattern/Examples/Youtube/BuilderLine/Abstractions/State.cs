using StatePattern.Examples.Youtube.BuilderLine.Entity;

namespace StatePattern.Examples.Youtube.BuilderLine.Abstractions
{
    internal abstract class State
    {
        protected TrafficLight trafficLight;

        internal TrafficLight TrafficLight { get => trafficLight; set => trafficLight = value; }

        public abstract void NextState();
        public abstract void PreviusState();
    }
}
