﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        public int width;
        public int height;
        public int perimeter;
        public int area;

        public Rectangle()
        {
            width = 0;
            height = 0;
        }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
            findPerimeter();
            findArea();

        }
        public void findPerimeter()
        {
            perimeter = width * 2 + height * 2;
        }
        public void findArea()
        {
            area = width * height;
        }
        public override string ToString()
        {
            return "Perimeter = " + perimeter + "\narea = " + area;
        }
    }
}
