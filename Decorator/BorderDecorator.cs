using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BorderDecorator : Decorator
    {
        private IWidget wid;

        public BorderDecorator(IWidget w)
        {
            this.wid = w;
        }

        public void Draw()
        {
            Console.WriteLine("Border Decorator");
        }
    }
}