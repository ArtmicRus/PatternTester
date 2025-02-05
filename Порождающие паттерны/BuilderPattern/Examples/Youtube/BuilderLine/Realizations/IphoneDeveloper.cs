using BuilderPattern.Examples.Youtube.BuilderLine.Entity;
using BuilderPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace BuilderPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class IphoneDeveloper : IDeveloper
    {
        private Phone phone;

        public IphoneDeveloper()
        {
            this.phone = new Phone();
        }

        public void CreateBox()
        {
            phone.AppendData("Произведён корпус Iphone; ");
        }

        public void CreateDisplay()
        {
            phone.AppendData("Произведён дисплей Iphone; ");
        }

        public void SystemInstall()
        {
            phone.AppendData("Установлена ОС IOS; ");
        }

        public Phone GetPhone()
        {
            return phone;
        }
    }
}
