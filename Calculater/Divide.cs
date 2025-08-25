using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIVCalculater
{
    public class Divide
    {
        public void DIVIDE() 
        {
            Console.WriteLine("Welcome,\nYou are performing Division");
            double dividend, divisor;
            while (true)
            {
                Console.Write("\nEnter Dividend: ");
                try
                {
                    dividend = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Error: Please enter only Numbers.");
                }
            }
            while (true)
            {
                Console.Write("Enter Divisor: ");
                try
                {
                    divisor = double.Parse(Console.ReadLine());
                    if (divisor == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else break;
                }
                catch
                {
                    Console.WriteLine("Error: Please enter only Numbers.");
                }
            }
            Console.WriteLine($"Division of {dividend} / {divisor} = {dividend / divisor}");
        }
    }
}
