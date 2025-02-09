using MediatorPattern.Examples.Youtube.BuilderLine.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Examples.Youtube.BuilderLine.Interfaces
{
    internal interface IMediator
    {
        public void Notiry(Emploee emp, string msg);
    }
}
