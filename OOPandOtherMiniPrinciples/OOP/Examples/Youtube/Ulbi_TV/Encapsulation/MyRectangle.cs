namespace OOP.Examples.Youtube.Ulbi_TV.Encapsulation
{
    /// <summary>
    /// Класс пример инкапсуляции 1
    /// </summary>
    internal class MyRectangle
    {
        /// <summary>
        /// Приватное поле которое является примером для инкапсуляции, его нельзя изменить напрямую а только через свойство Width
        /// </summary>
        private int _width;
        private int _height { get; set; }

        public MyRectangle(int width, int height, int radius)
        {
            _width = width;
            _height = height;
        }

        /// <summary>
        /// Открытое свойство которое проверяет данные для присвоения в поле
        /// </summary>
        public int Width
        {
            get { return _width; }
            set
            {
                // Проверка, валидно ли значение ширины
                if (value <= 0)
                {
                    _width = 1;
                }
                else
                {
                    _width = value;
                }
            }
        }

        public int CalcArea() => _width * _height;
    }
}
