using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Decorator : IWidget
    {
        private IWidget wid; 

        public Decorator(IWidget w)
        {

        }

        public void Draw()
        {

        }
    }
}
