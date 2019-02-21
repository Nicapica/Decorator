// Author: Nicholas Pica
// File: Decorator.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Decorator : IWidget
    {
        private IWidget wid;

        public Decorator(IWidget w)
        {
            this.wid = w;
        }

        public void Draw()
        {
            Console.WriteLine("This is a decorator holding a: ");
        }
    }
}
