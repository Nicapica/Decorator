// Author: Nicholas Pica
// File: ScrollDecorator.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ScrollDecorator : Decorator
    {

        public ScrollDecorator(IWidget w) : base(w)
        {
            Draw();
        }

        public new void Draw()
        {
            Console.WriteLine("Scroll Decorator");
        }
    }
}
