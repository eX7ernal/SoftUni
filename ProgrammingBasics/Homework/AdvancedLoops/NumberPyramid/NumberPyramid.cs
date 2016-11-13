using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int breaker = 0;
            int num = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", num);
                    breaker = num;
                    if (breaker == n) break;
                    num += 1;
                }
                if (breaker == n) break;
                Console.WriteLine();
            }
        }
    }
}
