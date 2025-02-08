namespace OOP.Examples.Youtube.Ulbi_TV.Inheritance
{
    internal class Employee : Person
    {
        private string _inn;
        private string _passportNumber;
        private string _snils;

        public Employee(string firstName, string lastName, int age, string inn, string passportNumber, string snils) 
            : base(firstName, lastName, age)
        {
            _inn = inn;
            _passportNumber = passportNumber;
            _snils = snils;
        }
    }
}
