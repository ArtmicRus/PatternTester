namespace OOP.Examples.Youtube.Ulbi_TV.Polymorphism
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

        /// <summary>
        /// Метод (или даже поле) базового класса переопределяется словом new
        /// </summary>
        public override void Greatings()
        {
            Console.WriteLine("Привет я работник: {0}", FullName());
        }
    }
}
