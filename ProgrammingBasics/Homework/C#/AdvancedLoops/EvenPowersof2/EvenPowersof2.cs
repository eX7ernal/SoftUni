using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersof2
{
    class EvenPowersof2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            Console.WriteLine(num);
            for (int i = 1; i <= n; i++)
            {
                num = num * 2;
                if (i % 2 == 0)
                    Console.WriteLine(num);
            }
        }
    }
}
