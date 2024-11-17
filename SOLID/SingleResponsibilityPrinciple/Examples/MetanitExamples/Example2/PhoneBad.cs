namespace SingleResponsibilityPrinciple.Examples.MetanitExamples.Example2
{
    /// <summary>
    /// 
    /// </summary>
    class PhoneBad
    {
        public string Model { get; }
        public int Price { get; }
        public PhoneBad(string model, int price)
        {
            Model = model;
            Price = price;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class MobileStoreBad
    {
        List<PhoneBad> phones = new();
        public void Process()
        {
            // ввод данных
            Console.WriteLine("Введите модель:");
            string? model = Console.ReadLine();
            Console.WriteLine("Введите цену:");

            // валидация
            bool result = int.TryParse(Console.ReadLine(), out var price);

            if (result == false || price <= 0 || string.IsNullOrEmpty(model))
            {
                throw new Exception("Некорректно введены данные");
            }
            else
            {
                phones.Add(new PhoneBad(model, price));
                // сохраняем данные в файл
                using (StreamWriter writer = new StreamWriter("store.txt", true))
                {
                    writer.WriteLine(model);
                    writer.WriteLine(price);
                }
                Console.WriteLine("Данные успешно обработаны");
            }
        }
    }
}
