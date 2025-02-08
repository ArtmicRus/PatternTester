namespace OOP.Examples.Youtube.Ulbi_TV.Polymorphism
{
    internal class Developer : Employee
    {
        private string _level;
        private string _language;

        public Developer(string firstName, string lastName, int age, string inn, string passportNumber, string snils, string level, string language)
            : base(firstName, lastName, age, inn, passportNumber, snils)
        {
            _level = level;
            _language = language;
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Greatings()
        {
            Console.WriteLine("Привет я разработчик: {0}", FullName());
        }
    }
}
