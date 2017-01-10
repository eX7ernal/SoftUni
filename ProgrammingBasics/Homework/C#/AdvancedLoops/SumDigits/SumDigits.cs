using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            do
            {
                result += num % 10;
                num = num / 10;
            }
            while (num > 0);
            Console.WriteLine(result);
        }
    }
}
