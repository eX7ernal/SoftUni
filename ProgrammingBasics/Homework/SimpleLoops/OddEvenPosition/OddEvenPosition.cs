using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = 1000000000.0;
            double oddMax = -1000000000.0;
            double evenSum = 0;
            double evenMin = 1000000000.0;
            double evenMax = -1000000000.0;
            double num;
            for (int i = 1; i <= n; i++)
            {
                num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num > evenMax) evenMax = num;
                    if (num < evenMin) evenMin = num;
                }

                else if (i % 2 == 1)
                {
                    oddSum += num;
                    if (num > oddMax) oddMax = num;
                    if (num < oddMin) oddMin = num;
                }
            }
            Console.WriteLine("OddSum="+ oddSum);
            if (oddMin == 1000000000.0) Console.WriteLine("OddMin=No");
            else Console.WriteLine("OddMin="+ oddMin);
            if (oddMax == -1000000000.0) Console.WriteLine("OddMax=No");
            else Console.WriteLine("OddMax="+ oddMax);
            Console.WriteLine("EvenSum="+ evenSum);
            if (evenMin == 1000000000.0) Console.WriteLine("EvenMin=No");
            else Console.WriteLine("EvenMin=" + evenMin);
            if (evenMax == -1000000000.0) Console.WriteLine("EvenMax=No");
            else Console.WriteLine("EvenMax=" + evenMax);
        }
    }
}
