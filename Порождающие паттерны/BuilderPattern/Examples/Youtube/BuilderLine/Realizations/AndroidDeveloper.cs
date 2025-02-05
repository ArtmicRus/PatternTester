using BuilderPattern.Examples.Youtube.BuilderLine.Entity;
using BuilderPattern.Examples.Youtube.BuilderLine.Interfaces;

namespace BuilderPattern.Examples.Youtube.BuilderLine.Realizations
{
    internal class AndroidDeveloper : IDeveloper
    {
        private Phone phone;

        public AndroidDeveloper()
        {
            this.phone = new Phone();
        }

        public void CreateBox()
        {
            phone.AppendData("Произведён корпус Samsung; ");
        }

        public void CreateDisplay()
        {
            phone.AppendData("Произведён дисплей Samsung; ");
        }

        public void SystemInstall()
        {
            phone.AppendData("Установлена ОС Android; ");
        }

        public Phone GetPhone()
        {
            return phone;
        }
    }
}
