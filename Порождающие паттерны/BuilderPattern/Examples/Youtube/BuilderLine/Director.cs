using BuilderPattern.Examples.Youtube.BuilderLine.Entity;
using BuilderPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace BuilderPattern.Examples.Youtube.BuilderLine
{
    /// <summary>
    /// Для управленяи разработчиками
    /// </summary>
    internal class Director
    {
        private IDeveloper developer;

        public Director(IDeveloper developer)
        {
            this.developer = developer;
        }

        public void SetDeveloper(IDeveloper dev) => developer = dev;

        public Phone MountOnlyPhone()
        {
            developer.CreateBox();
            developer.CreateDisplay();
            return developer.GetPhone();
        }

        public Phone MountFullPhone()
        {
            developer.CreateBox();
            developer.CreateDisplay();
            developer.SystemInstall();
            return developer.GetPhone();
        }
    }
}
