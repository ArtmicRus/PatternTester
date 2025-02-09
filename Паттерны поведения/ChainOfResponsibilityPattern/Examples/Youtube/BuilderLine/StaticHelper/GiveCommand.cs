using ChainOfResponsibilityPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace ChainOfResponsibilityPattern.Examples.Youtube.BuilderLine.StaticHelper
{
    internal class GiveCommand
    {
        public static void GiveCommander(IWorker worker, string command)
        {
            string str = worker.Execute(command);
            if (str == "") 
            {
                Console.WriteLine(command + " - никто не умеет делать");
            }
            else
            {
                Console.WriteLine(str);
            }
        }
    }
}
