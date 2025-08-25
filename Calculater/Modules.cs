using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODCalculater
{
    public class Modules
    {
        public void MODULS() 
        {
            Console.WriteLine("Welcome,\nYou are performing Modulus");
            int num1, num2;
            while (true)
            {
                Console.Write("\nEnter First Number (dividend): ");
                try
                {
                    num1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Error: Please enter only Numbers.");
                }
            }
            while (true)
            {
                Console.Write("Enter Second Number (Divisor): ");
                try
                {
                    num2 = int.Parse(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Modulus by zero is not allowed.");
                    }
                    else break;
                }
                catch
                {
                    Console.WriteLine("Error: Please enter only Numbers.");
                }
            }
            Console.WriteLine($"Modulus of {num1} % {num2} = {num1 % num2}");
        }
    }
}
