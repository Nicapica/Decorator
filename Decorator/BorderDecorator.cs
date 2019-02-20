using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BorderDecorator : Decorator
    {
        Widget widget;

        public BorderDecorator(Widget w)
        {
            this.widget = w;
        }

        public void Draw()
        {
            Console.WriteLine("I am a border decorator holding a:");
        }
    }
}