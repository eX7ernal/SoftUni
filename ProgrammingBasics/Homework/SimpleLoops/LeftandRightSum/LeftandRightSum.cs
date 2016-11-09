using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftandRightSum
{
    class LeftandRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num, leftSum, rightSum, difference;
            leftSum = 0;
            rightSum = 0;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    num = int.Parse(Console.ReadLine());
                    leftSum += num;
                }
                for (int j = 1; j <= n; j++)
                {
                    num = int.Parse(Console.ReadLine());
                    rightSum += num;
                }
            }
            if (leftSum == rightSum) Console.WriteLine("Yes, sum = {0}", leftSum);
            else
            {
                difference = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, diff = {0}", difference);
            }
        }
    }
}
