using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cars = 0;
            int microbus = 0;
            int smallbus = 0;
            int bigbus = 0;
            int train = 0;
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                int group = int.Parse(Console.ReadLine());
                if (group <=5)
                {
                    cars += group;
                }
                else if (group > 5 && group <= 12)
                {
                    microbus += group;
                }
                else if (group > 12 && group <= 25)
                {
                    smallbus += group;
                }
                else if (group > 25 && group <= 40)
                {
                    bigbus += group;
                }
                else if (group > 40)
                {
                    train += group;
                }
                else if (group == 0)
                {
                    total += group;
                }
                total += group;
            }
            Console.WriteLine("{0:f2}%", ((double)cars / total) * 100);
            Console.WriteLine("{0:f2}%", ((double)microbus / total) * 100);
            Console.WriteLine("{0:f2}%", ((double)smallbus / total) * 100);
            Console.WriteLine("{0:f2}%", ((double)bigbus / total) * 100);
            Console.WriteLine("{0:f2}%", ((double)train / total) * 100);
        }
    }
}
