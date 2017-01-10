using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double height = Math.Abs(x1 - x2);
            double width = Math.Abs(y1 - y2);
            double area = height * width;
            double perimeter = 2 * (height + width);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
