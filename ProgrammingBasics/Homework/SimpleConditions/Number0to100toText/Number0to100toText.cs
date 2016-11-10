using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0to100toText
{
    class Number0to100toText
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int decPart = number / 10;
            int digPart = number % 10;
            string text = "";
            if (number <= 19)
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    case 10:
                        Console.WriteLine("ten");
                        break;
                    case 11:
                        Console.WriteLine("eleven");
                        break;
                    case 12:
                        Console.WriteLine("twelve");
                        break;
                    case 13:
                        Console.WriteLine("thirteen");
                        break;
                    case 14:
                        Console.WriteLine("fourteen");
                        break;
                    case 15:
                        Console.WriteLine("fifteen");
                        break;
                    case 16:
                        Console.WriteLine("sixteen");
                        break;
                    case 17:
                        Console.WriteLine("seventeen");
                        break;
                    case 18:
                        Console.WriteLine("eighteen");
                        break;
                    case 19:
                        Console.WriteLine("nineteen");
                        break;
                    case 20:
                        Console.WriteLine("twenty");
                        break;
                }
            }
            else if (number > 20 & number < 100)
            {
                switch (decPart)
                {
                    case 2:
                        text = "twenty";
                        break;
                    case 3:
                        text = "thirty";
                        break;
                    case 4:
                        text = "fourty";
                        break;
                    case 5:
                        text = "fifty";
                        break;
                    case 6:
                        text = "sixty";
                        break;
                    case 7:
                        text = "seventy";
                        break;
                    case 8:
                        text = "eighty";
                        break;
                    case 9:
                        text = "ninety";
                        break;
                }
                switch (digPart)
                {
                    case 1:
                        text = text + " one";
                        break;
                    case 2:
                        text = text + " two";
                        break;
                    case 3:
                        text = text + " three";
                        break;
                    case 4:
                        text = text + " four";
                        break;
                    case 5:
                        text = text +" five";
                        break;
                    case 6:
                        text = text + " six";
                        break;
                    case 7:
                        text = text + " seven";
                        break;
                    case 8:
                        text = text + " eight";
                        break;
                    case 9:
                        text = text + " nine";
                        break;
                    case 0:
                        break;
                }
            }
            else if (number == 100)
                Console.WriteLine("one hundred");
            Console.WriteLine(text);
            }
        }
}
