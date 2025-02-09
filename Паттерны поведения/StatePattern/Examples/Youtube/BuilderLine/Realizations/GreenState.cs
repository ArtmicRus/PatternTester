using StatePattern.Examples.Youtube.BuilderLine.Abstractions;

namespace StatePattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class GreenState : State
    {
        public override void NextState()
        {
            Console.WriteLine("Из зелёного в жёлтый");
            trafficLight.SetState(new YellowState());
        }

        public override void PreviusState()
        {
            Console.WriteLine("Зелёный цвет");
        }
    }
}
