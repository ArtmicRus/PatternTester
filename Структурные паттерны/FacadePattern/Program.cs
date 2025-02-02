using FacadePattern.Examples.Metanit.Entity;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Фасад (Facade) представляет шаблон проектирования, который позволяет скрыть сложность системы
            // с помощью предоставления упрощенного интерфейса для взаимодействия с ней.

            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            CLR clr = new CLR();

            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);
        }
    }
}
