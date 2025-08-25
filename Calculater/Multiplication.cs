using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULTICalculater
{
    public class Multiplication
    {
        public void MULTIPALICATION()
        {
            Console.WriteLine("Welcome,\nYou are performing Multiplication");
            int countMulti;
            while (true)
            {
                Console.Write("\nEnter the number variable you want to input: ");
                try
                {
                    countMulti = int.Parse(Console.ReadLine());

                    if (countMulti <= 0)
                    {
                        Console.WriteLine("Error: Please enter a number greater than 0.");
                        continue;
                    }

                    else if (countMulti > 0)
                    {
                        double multi = 1;
                        for (int i = 1; i <= countMulti; i++)
                        {
                            while (true)
                            {
                                Console.Write($"Enter Value {i}: ");
                                try
                                {
                                    double value = double.Parse(Console.ReadLine());
                                    multi *= value;
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Error: Please enter only Numbers in value.");
                                }
                            }
                        }

                        Console.WriteLine($"Multiplication of all {countMulti} Numbers = " + multi);
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
