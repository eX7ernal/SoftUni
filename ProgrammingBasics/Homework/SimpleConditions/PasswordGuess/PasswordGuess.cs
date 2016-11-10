using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGuess
{
    class PasswordGuess
    {
        static void Main(string[] args)
        {
            string guess = Console.ReadLine();
            string pass = "s3cr3t!P@ssw0rd";
            if (guess == pass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
