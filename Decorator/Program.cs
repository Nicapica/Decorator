using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IWidget w1 = new BorderDecorator(new TextField);
            w1.Draw();
            IWidget w2 = new ScrollDecorator(new TextField);
            w2.Draw();
            IWidget w3 = new ColorDecorator(new TextField);
            w3.Draw();
        }
    }
}
