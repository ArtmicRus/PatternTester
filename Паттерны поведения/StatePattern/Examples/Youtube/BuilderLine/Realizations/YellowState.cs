using StatePattern.Examples.Youtube.BuilderLine.Abstractions;

namespace StatePattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class YellowState : State
    {
        public override void NextState()
        {
            Console.WriteLine("Из жёлтоого в красный цвет");
            trafficLight.SetState(new RedState());
        }

        public override void PreviusState()
        {
            Console.WriteLine("Из жёлтоого в зелёный цвет");
            trafficLight.SetState(new GreenState());
        }
    }
}