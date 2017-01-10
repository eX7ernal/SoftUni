using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            int fib0 = 1;
            int fib1 = 1;
            if (n < 2)
                result = 1;
            else if (n >= 2)
            {
                for (int i = 2; i <= n; i++)
                {
                    result = fib0 + fib1;
                    fib0 = fib1;
                    fib1 = result;
                }
            }
 
            Console.WriteLine(result);
        }
    }
}
