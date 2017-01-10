using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int r = 1; r <= n; r++)
            {
                if (r == 1)
                {
                    Console.Write("+");
                    for (int i = 0; i < n - 2; i++) Console.Write(" -");
                    Console.WriteLine(" +");
                }
                else if (r == n)
                {
                    Console.Write("+");
                    for (int i = 0; i < n - 2; i++) Console.Write(" -");
                    Console.WriteLine(" +");
                }
                else
                {
                    Console.Write("|");
                    for (int i = 0; i < n - 2; i++) Console.Write(" -");
                    Console.WriteLine(" |");
                }

            }
        }
    }
}
