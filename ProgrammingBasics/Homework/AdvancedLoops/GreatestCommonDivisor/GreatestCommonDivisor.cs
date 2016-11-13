using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = Math.Min(a, b);
            int gcd = 0;
            for (int i = 1; i <= c; i++)
            {
                if ((a % i == 0) && (b % i == 0)) gcd = i;
            }
            Console.WriteLine(gcd);
        }
    }
}
