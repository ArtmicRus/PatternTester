namespace OOP.Examples.Youtube.Ulbi_TV.Polymorphism
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

        /// <summary>
        /// Если писать new в производных классах
        /// Это (как я понял) уберёт из области видимости производного класса метод родительского класса
        /// Но при прохождении foreach по всем наследникам вызываться будет БАЗОВЫЙ МЕТОД
        /// То есть конкретно этот
        /// 
        /// Если использовать virtual(для базового класса) и override (для производных классов)
        /// то это ПОЛНОСТЬЮ ПЕРЕОПРЕДЕЛИТ метод и будет при прохождении foreach вызывать метод каждого конкретного класса
        /// </summary>
        public virtual void Greatings()
        {
            Console.WriteLine("Привет я человек: {0}", FullName());
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
