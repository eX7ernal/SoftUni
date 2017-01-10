using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class SquareArea
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            int area = a * a;
            Console.WriteLine("The area of a square with a side {0} is {1}", a, area);
        }
    }
}
