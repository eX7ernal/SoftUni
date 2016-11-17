using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int hundreds = 0;
            int tens = 0;
            int singles = 0;
            int rows = 0;
            int cols = 0;
            rows = (num / 100) + ((num / 10) % 10);
            cols = (num / 100) + (num % 10);
            for (int i = 1; i >= rows; i++)
            {
                for (int j = 1; j >= cols; j++)
                {
                    if (num % 5 == 0)
                    {
                        hundreds = num / 100;
                        num -= hundreds;
                        Console.Write(num);
                    }
                    else if (num % 3 == 0)
                    {
                        tens = (num / 10) % 10;
                        num -= tens;
                        Console.Write(num);
                    }
                    else
                    {
                        singles = num % 10;
                        num += singles;
                        Console.Write(num);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
