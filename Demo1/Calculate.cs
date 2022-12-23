using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Calculate
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 5);
            Console.WriteLine("Area : {0}", rectangle.getArea());
            Console.ReadKey();
        }
    }
}
