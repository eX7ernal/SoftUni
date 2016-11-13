using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class FallenInLove
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", new string('~', i), new string('.', (2 * n) - (2 * i)), new string('.', i * 2));
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}", new string('.', (i * 2) + 1), new string('~', (n - i)), new string('.', (2 * n) - (2 * i)));
            }
            Console.WriteLine("{0}####{0}", new string('.', (2 * n) + 1));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}##{0}", new string('.', (n * 2) + 2));
            }
        }
    }
}
