namespace CommandPattern.Examples.Youtube.BuilderLine.Entity
{
    internal class Conveyor
    {
        public void On() => Console.WriteLine("Конвейер запущен");
        public void Off() => Console.WriteLine("Конвейер остановлен");
        public void SpeedIncrease() => Console.WriteLine("Увеличина скорость конвейера");
        public void SpeedDecrease() => Console.WriteLine("Снижена скорость конвейера");
    }
}
