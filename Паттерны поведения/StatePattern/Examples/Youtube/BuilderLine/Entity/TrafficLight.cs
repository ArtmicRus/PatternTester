using StatePattern.Examples.Youtube.BuilderLine.Abstractions;

namespace StatePattern.Examples.Youtube.BuilderLine.Entity
{
    internal class TrafficLight
    {
        private State _state;

        public TrafficLight(State state)
        {
            SetState(state);
        }

        public void SetState(State state)
        {
            _state = state;
            _state.TrafficLight = this;
        }

        public void NextState()
        {
            _state.NextState();
        }

        public void PreviousState()
        {
            _state.PreviusState();
        }
    }
}
