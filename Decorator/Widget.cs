using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    interface IWidget
    {
        public void Draw()
        {
            Console.WriteLine("draws a widget");
        }
    }
}
