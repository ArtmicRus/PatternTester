using StatePattern.Examples.Youtube.BuilderLine.Abstractions;

namespace StatePattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class RedState : State
    {
        public override void NextState()
        {
            Console.WriteLine("Красный цвет");
        }

        public override void PreviusState()
        {
            Console.WriteLine("Из красного в жёлтый");
            trafficLight.SetState(new YellowState());
        }
    }
}