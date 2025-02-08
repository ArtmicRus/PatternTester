namespace OOP.Examples.Youtube.Ulbi_TV.Inheritance
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        public string FullName()
        {
            return $"Фамилия - {_lastName} Имя - {_firstName}";
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Age 
        { 
            get => _age; 
            set
            {
                if (value < 0)
                    _age = 0;
                else
                    _age = value;
            }
        }
    }
}
