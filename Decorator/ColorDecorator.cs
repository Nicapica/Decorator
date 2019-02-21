using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ColorDecorator : Decorator
    {
        IWidget widget;

        public ColorDecorator(IWidget w)
        {
            this.widget = w;
        }

        public void Draw()
        {
            Console.WriteLine("Color Decorator");
        }
    }
}
