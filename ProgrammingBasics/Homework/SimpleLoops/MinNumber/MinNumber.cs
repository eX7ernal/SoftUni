using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num;
            long min = 10000000000000;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    num = int.Parse(Console.ReadLine());
                    if (num < min) min = num;
                }
            }
            Console.WriteLine(min);
        }
    }
}
