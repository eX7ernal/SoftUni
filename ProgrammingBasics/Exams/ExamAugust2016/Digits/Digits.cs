using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int hundreds = num / 100;
            int decimals = (num / 10) % 10;
            int singles = num % 10;
            int rows = 0;
            int cols = 0;
            rows = (num / 100) + ((num / 10) % 10);
            cols = (num / 100) + (num % 10);
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    if (num % 5 == 0)
                    {
                        num -= hundreds;
                        Console.Write("{0} ", num);
                    }
                    else if (num % 3 == 0)
                    {
                        num -= decimals;
                        Console.Write("{0} ", num);
                    }
                    else
                    {
                        num += singles;
                        Console.Write("{0} ", num);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
