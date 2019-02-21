﻿// Author: Nicholas Pica
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
        private IWidget wid;

        public ColorDecorator(IWidget w) : base(w)
        {
            this.wid = w;
        }

        public new void Draw()
        {
            Console.WriteLine("Color Decorator");
        }
    }
}
