// Author: Nicholas Pica
// File: BorderDecorator.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BorderDecorator : Decorator
    {
        public BorderDecorator(IWidget w):base(w)
        {
            base.Draw();
            Draw();
        }

        public new void Draw()
        {
            Console.WriteLine("Border Decorator");
        }
    }
}