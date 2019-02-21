// Author: Nicholas Pica
// File: Program.cs
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
            TextField tf = new TextField(3, 2);
            BorderDecorator bd = new BorderDecorator(tf);
            ScrollDecorator sd = new ScrollDecorator(bd);
            ColorDecorator cd = new ColorDecorator(sd);
            Console.ReadKey();
        }
    }
}
