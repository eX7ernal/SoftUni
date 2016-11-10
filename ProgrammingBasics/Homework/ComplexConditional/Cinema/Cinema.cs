using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            type = type.ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double result;
            if (type == "premiere")
            {
                result = columns * rows * 12.00;
                Console.WriteLine("{0:f2}",result);
            }
            else if (type == "normal")
            {
                result = columns * rows * 7.50;
                Console.WriteLine("{0:f2}", result);
            }
            else if (type == "discount")
            {
                result = columns * rows * 5.00;
                Console.WriteLine("{0:f2}", result);
            }
        }
    }
}
