using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedAnswers
{
    class EncodedAnswers
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string[] answers = new string[n];
            long answersA = 0;
            long answersB = 0;
            long answersC = 0;
            long answersD = 0;
            for (int i = 0; i < n; i++)
            {
                long question = long.Parse(Console.ReadLine());
                if (question % 4 == 0)
                {
                    answersA++;
                    answers[i] = "a";
                }
                else if (question % 4 == 1)
                {
                    answersB++;
                    answers[i] = "b";
                }
                else if (question % 4 == 2)
                {
                    answersC++;
                    answers[i] = "c";
                }
                else
                {
                    answersD++;
                    answers[i] = "d";
                }
            }
            Console.WriteLine(string.Join(" ",answers));
            Console.WriteLine("Answer A: " + answersA);
            Console.WriteLine("Answer B: " + answersB);
            Console.WriteLine("Answer C: " + answersC);
            Console.WriteLine("Answer D: " + answersD);
        }
    }
}
