﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class TextField : IWidget
    {
        private int width;
        private int height;

        public TextField(int w, int h)
        {

        }

        public void Draw()
        {
            Console.WriteLine("draws a textfield");
        }
    }
}
