using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDCalculater
{
    public class Addition
    {
        public void ADDITION() {
            Console.WriteLine("Welcome,\nYou are performing Addition");
            int count;
            while (true)
            {
                Console.Write("\nEnter the number variable you want to input:");
                try
                {                  
                    count = int.Parse(Console.ReadLine());
                    if (count <= 0)
                    {
                        Console.WriteLine("Error: Please enter a positive number greater than zero.");
                        continue;
                    }
                    else if (count > 0) 
                    {
                        double sum = 0;
                        for (int i = 1; i <= count; i++)
                        {
                            while (true)
                            {
                                Console.Write($"Enter Value {i}: ");
                                try
                                {
                                    sum += double.Parse(Console.ReadLine());
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Error: Please enter only Numbers in value.");
                                }
                            }
                        }
                        Console.WriteLine($"Sum of all {count} Numbers = " + sum);
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Error: Invalid input variable, only number is allowed.");
                }
            }            
        }
    }
}
