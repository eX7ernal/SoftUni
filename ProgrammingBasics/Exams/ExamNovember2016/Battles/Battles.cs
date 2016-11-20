using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Battles
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                if (count <= max)
                {
                    for (int j = 1; j <= m; j++)
                    {
                        if (count <= max)
                        {
                            Console.Write("({0} <-> {1}) ", i, j);
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
