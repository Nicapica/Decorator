// Author: Nicholas Pica
// File: ColorDecorator.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ColorDecorator : Decorator
    {
        public ColorDecorator(IWidget w) : base(w)
        {
            Draw();
        }

        public new void Draw()
        {
            Console.WriteLine("Color Decorator");
        }
    }
}
