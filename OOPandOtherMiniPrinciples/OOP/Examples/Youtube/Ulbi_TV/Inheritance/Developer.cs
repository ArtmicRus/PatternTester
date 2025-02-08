namespace OOP.Examples.Youtube.Ulbi_TV.Inheritance
{
    internal class Developer : Employee
    {
        private string _level;
        private string _language;

        public Developer(string firstName, string lastName, int age, string inn, string passportNumber, string snils, string level, string language = null)
            : base(firstName, lastName, age, inn, passportNumber, snils)
        {
            _level = level;
            _language = language;
        }
    }
}
