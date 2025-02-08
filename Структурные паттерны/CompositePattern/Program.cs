using CompositePattern.Examples.Metanit.Abstractions;
using CompositePattern.Examples.Metanit.Realizations;
using CompositePattern.Examples.Youtube.BuilderLine.Abstractions;
using CompositePattern.Examples.Youtube.BuilderLine.Realizations;

namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Паттерн Компоновщик (Composite) объединяет группы объектов в древовидную структуру
            // по принципу "часть-целое" и позволяет клиенту одинаково работать как с отдельными объектами,
            // так и с группой объектов.

            // Образно реализацию паттерна можно представить в виде меню, которое имеет различные пункты.
            // Эти пункты могут содержать подменю, в которых, в свою очередь, также имеются пункты.
            // То есть пункт меню служит с одной стороны частью меню, а с другой стороны еще одним меню.
            // В итоге мы однообразно можем работать как с пунктом меню, так и со всем меню в целом.

            // СТОИТ ЗАМЕТИТЬ ЧТО ЕСТЬ РЕАЛИЗАЦИЯ ЭТОГО ПАТТЕРНА В using System.ComponentModel;
            // Можно рассмотреть

            #region Metanit

            Component fileSystem = new MyDirectory("Файловая система");
            // определяем новый диск
            Component diskC = new MyDirectory("Диск С");
            // новые файлы
            Component pngFile = new MyFile("12345.png");
            Component docxFile = new MyFile("Document.docx");
            // добавляем файлы на диск С
            diskC.Add(pngFile);
            diskC.Add(docxFile);
            // добавляем диск С в файловую систему
            fileSystem.Add(diskC);
            // выводим все данные
            fileSystem.Print();
            Console.WriteLine();
            // удаляем с диска С файл
            diskC.Remove(pngFile);
            // создаем новую папку
            Component docsFolder = new MyDirectory("Мои Документы");
            // добавляем в нее файлы
            Component txtFile = new MyFile("readme.txt");
            Component csFile = new MyFile("Program.cs");
            docsFolder.Add(txtFile);
            docsFolder.Add(csFile);
            diskC.Add(docsFolder);

            fileSystem.Print();

            #endregion

            #region BuilderLine
            Console.WriteLine();

            Item file = new DropDownItem("Файл->");

            Item create = new DropDownItem("Создать->");
            Item open = new DropDownItem("Открыть->");
            Item exit = new ClicableItem("Выход");

            file.Add(create);
            file.Add(open);
            file.Add(exit);

            Item project = new ClicableItem("Проект...");
            Item repository = new ClicableItem("Репозиторий...");

            create.Add(project);
            create.Add(repository);

            Item solution = new ClicableItem("Решение...");
            Item folder = new ClicableItem("Папка...");

            open.Add(solution);
            open.Add(folder);

            file.Display();
            Console.WriteLine();

            file.Remove(create);

            file.Display();

            #endregion
        }
    }
}
