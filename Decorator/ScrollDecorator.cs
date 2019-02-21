using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ScrollDecorator : Decorator
    {
        private IWidget wid;

        public ScrollDecorator(IWidget w)
        {
            this.wid = w;
        }

        public new void Draw()
        {
            Console.WriteLine("Scroll Decorator");
        }
    }
}
