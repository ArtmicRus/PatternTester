namespace SingleResponsibilityPrinciple.Examples.MetanitExamples.Example1
{
    /// <summary>
    /// ReportGood занимается выполнением одной обязанности, новигации по страницам
    /// </summary>
    class ReportGood
    {
        // Обязанность 1 - Новигация по страницам отчёта
        public string Text { get; set; } = "";
        public void GoToFirstPage() =>
            Console.WriteLine("Переход к первой странице");

        public void GoToLastPage() =>
            Console.WriteLine("Переход к последней странице");

        public void GoToPage(int pageNumber) =>
            Console.WriteLine($"Переход к странице {pageNumber}");
    }

    /// <summary>
    /// Выделение обязанности печати отчёта ищ класса Report
    /// </summary>
    class Printer
    {
        // Обязанность 1 - Печать отчёта
        public void PrintReport(ReportGood report)
        {
            Console.WriteLine("Печать отчета");
            Console.WriteLine(report.Text);
        }
    }
}
