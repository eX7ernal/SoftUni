using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaofFigures
{
    class AreaofFigures
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double area = Math.PI*r*r;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "triangle")
            {
                double h = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = (h * b) / 2;
                Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
}
