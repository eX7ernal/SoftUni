using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            int num , difference;
            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (i % 2 == 0) evenSum += num;
                else if (i % 2 == 1) oddSum += num;
            }
            difference = Math.Abs(evenSum - oddSum);
            if (evenSum == oddSum) Console.WriteLine("Yes Sum = "+ evenSum);
            else Console.WriteLine("No Diff = "+ difference);
        }
    }
}
