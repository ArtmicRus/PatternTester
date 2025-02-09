namespace Flyweight.Examples.Youtube.BuilderLine.Structures
{
    internal struct Shared
    {
        private string _company;
        private string _position;

        public Shared(string company, string position)
        {
            _company = company;
            _position = position;
        }

        public string Company { get { return _company; } }
        public string Position { get { return _position; } }
    }
}
