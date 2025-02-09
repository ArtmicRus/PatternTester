using CommandPattern.Examples.Youtube.BuilderLine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Examples.Youtube.BuilderLine.Entity
{
    internal class Multipult
    {
        private List<ICommand> commands;

        /// <summary>
        /// Для отмены команд
        /// </summary>
        private Stack<ICommand> history;

        public Multipult()
        {
            this.commands = new List<ICommand>() { null, null};
            this.history = new Stack<ICommand>();
        }

        public void SetCommand(int button, ICommand command)
        {
            commands[button] = command;
        }

        public void PressOn(int button)
        {
            commands[button].Positive();
            history.Push(commands[button]);
        }

        public void PressCancel()
        {
            if (history.Count != 0)
            {
                history.Pop().Negative();
            }
        }
    }
}
