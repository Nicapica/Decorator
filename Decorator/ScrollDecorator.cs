using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ScrollDecorator : Decorator
    {
        IWidget widget;

        public ScrollDecorator(IWidget w)
        {
            this.widget = w;
        }

        public void Draw()
        {
            Console.WriteLine("Scroll Decorator");
        }
    }
}
