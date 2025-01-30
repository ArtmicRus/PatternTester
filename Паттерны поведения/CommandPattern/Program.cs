﻿using CommandPattern.Examples.Metanit.Entities;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Паттерн "Команда" (Command) позволяет инкапсулировать запрос на выполнение определенного действия
            // в виде отдельного объекта. Этот объект запроса на действие и называется командой.
            // При этом объекты, инициирующие запросы на выполнение действия, отделяются от объектов,
            // которые выполняют это действие.

            // Команды могут использовать параметры, которые передают ассоциированную с командой информацию.
            // Кроме того, команды могут ставиться в очередь и также могут быть отменены.

            Pult pult = new Pult();
            TV tv = new TV();
            pult.SetCommand(new TVOnCommand(tv));
            pult.PressButton();
            pult.PressUndo();

            Console.Read();
        }
    }
}
