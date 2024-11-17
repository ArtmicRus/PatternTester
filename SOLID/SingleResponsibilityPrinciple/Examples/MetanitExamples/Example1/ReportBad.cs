namespace SingleResponsibilityPrinciple.Examples.MetanitExamples.Example1
{
    /// <summary>
    /// Основной смысл данного примера заключается в том что ReportBad не должен выполнять несколько обязанностей
    /// В данном случае он выполняет 2 обязанности, что не соответствует принципу SRP
    /// </summary>
    class ReportBad
    {
        // Обязанность 1 - Новигация по страницам отчёта
        public string Text { get; set; } = "";
        public void GoToFirstPage() =>
            Console.WriteLine("Переход к первой странице");

        public void GoToLastPage() =>
            Console.WriteLine("Переход к последней странице");

        public void GoToPage(int pageNumber) =>
            Console.WriteLine($"Переход к странице {pageNumber}");

        // Обязанность 2 - Печать отчёта
        public void Print()
        {
            Console.WriteLine("Печать отчета");
            Console.WriteLine(Text);
        }
    }
}
