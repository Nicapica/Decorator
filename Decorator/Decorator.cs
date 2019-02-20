using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Decorator : Widget
    {
        private Widget wid; 

        public Decorator(Widget w)
        {

        }

        public void Draw()
        {

        }
    }
}
