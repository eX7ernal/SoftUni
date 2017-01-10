using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int temp = 0;
            int maxDiff = 0;
            int tempDiff = 0;
            int num;
            int j = 1;
            int[] pairs = new int[n+1];
            for (int i = 1; i <= n * 2; i++)
            {
                num = int.Parse(Console.ReadLine());
                temp += num;
                if (i % 2 == 0)
                {
                    pairs[j] = temp;
                    temp = 0;
                    j++;
                }
            }
            for (j = 1; j <= n-1; j++)
            {
                tempDiff = Math.Abs((pairs[j] - pairs[j + 1]));
                if (maxDiff < tempDiff) maxDiff = tempDiff;
            }
            bool equality = true;
            int check = pairs[1];
            for (j = 1; j <= n; j++)
            {
                if (check == pairs[j]) equality = true;
                else if (check != pairs[j]) equality = false;
            }
            if (equality == true) Console.WriteLine("Yes, value=" + check);
            else if (equality == false) Console.WriteLine("No, maxdiff="+maxDiff);
        }
    }
}
