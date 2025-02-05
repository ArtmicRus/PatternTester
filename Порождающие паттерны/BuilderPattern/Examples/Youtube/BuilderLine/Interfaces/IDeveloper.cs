using BuilderPattern.Examples.Youtube.BuilderLine.Entity;

namespace BuilderPattern.Examples.Youtube.BuilderLine.Interfaces
{
    internal interface IDeveloper
    {
        void CreateDisplay();
        void CreateBox();
        void SystemInstall();
        Phone GetPhone();
    }
}
