using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(int width = 0, int height = 0)
        {
            Width = width;
            Height = height;
        }

        public override int getArea()
        {
            return Width * Height;
        }
    }
}
