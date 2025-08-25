using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUBCalculater
{
    public class Substraction
    {
        public void SUBTRACTION()
        {
            Console.WriteLine("Welcome,\nYou are performing Substraction");
            int count;
            while (true)
            {
               
                while (true)
                {
                    try
                    {
                        Console.Write("\nEnter the number variable you want to input:");
                        count = int.Parse(Console.ReadLine());
                        if (count <= 0)
                        {
                            Console.WriteLine("Error: Please enter a positive number greater than zero.");
                        }
                        else if (count > 0)
                        {
                            double sub = 0;
                            for (int i = 1; i <= count; i++)
                            {
                                while (true)
                                {
                                    Console.Write($"Enter Value {i}: ");
                                    try
                                    {
                                        double value = double.Parse(Console.ReadLine());
                                        if (i == 1) sub = value;
                                        else sub -= value;
                                        break;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Error: Please enter only Numbers in value.");
                                    }
                                }
                            }
                            Console.WriteLine($"Substraction of all {count} Numbers = " + sub);
                        }

                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Error: Invalid Input, Please Enter number in input variable");
                    }
                }
                break;
            }           
        }
    }
}
