using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num, difference;
            int max = -100000;
            int total = 0;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    num = int.Parse(Console.ReadLine());
                    total += num;
                    if (num > max) max = num;
                }
            }
            if (max == total - max) Console.WriteLine("Yes Sum = {0}", max);
            else
            {
                difference = Math.Abs(max - (total - max));
                Console.WriteLine("No Diff = {0}", difference);
            }
        }
    }
}
