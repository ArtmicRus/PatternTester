using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern.Examples.Youtube.BuilderLine.Interfaces
{
    internal interface IMemento
    {
        public int GetDollars();
        public int GetEuro();
    }
}
