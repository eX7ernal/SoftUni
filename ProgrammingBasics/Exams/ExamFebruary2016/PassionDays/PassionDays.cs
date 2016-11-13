using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionDays
{
    class PassionDays
    {
        static void Main(string[] args)
        {
            decimal startMoney = decimal.Parse(Console.ReadLine());
            bool isOver = false;
            bool hasBegun = false;
            long purchaseCount = 0;
            while (!isOver)
            {
                string action = Console.ReadLine();
                if (action == "mall.Enter")
                {
                    hasBegun = true;
                    continue;
                }
                if (action == "mall.Exit")
                {
                    isOver = true;
                    break;
                }
                if (hasBegun)
                {
                    byte[] values = Encoding.ASCII.GetBytes(action);
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (action[i] == '%' && startMoney > 0)
                        {
                            startMoney /= 2;
                            purchaseCount++;
                        }
                        else if (action[i] == '*')
                        {
                            startMoney += 10;
                        }
                        else if (Char.IsUpper(action[i]) && (startMoney>= (decimal)values[i] / 2))
                        {
                            startMoney -= (decimal)values[i] / 2;
                            purchaseCount++;
                        }
                        else if (Char.IsLower(action[i]) && (startMoney >= (decimal)(values[i] * 0.3)))
                        {
                            startMoney -= (decimal)(values[i] * 0.3);
                            purchaseCount++;
                        }
                        else
                        {
                            if (startMoney >= (decimal)values[i])
                            {
                                startMoney -= (decimal)values[i];
                                purchaseCount++;
                            }
                        }
                    }
                }
            }  
            if (purchaseCount > 0)
            {
                Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", purchaseCount, startMoney);
            }
            else
            {
                Console.WriteLine("No purchases. Money left: {0:f2} lv.", startMoney);
            }
        }
    }
}
