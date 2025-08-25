using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRCalculater
{
    public class Array1
    {
        public void ARRAY() 
        {
            Console.WriteLine("Welcome,\nYou are performing Array.");
            Console.Write("\nEnter Array name: ");
            string arr = Console.ReadLine();
            string filePath = "local_storage_array.txt";

            int count6;
            while (true)
            {
                Console.Write("\nEnter the number of array variables you want to input: ");
                try
                {
                    count6 = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Error: Invalid input variable, only number is allowed.");
                }
            }

            object[] values = new object[count6];
            for (int i = 0; i < count6; i++)
            {
                Console.Write($"Enter value for index {i}: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int intVal)) values[i] = intVal;
                else if (double.TryParse(input, out double doubleVal)) values[i] = doubleVal;
                else values[i] = input;
            }

            Console.WriteLine("\nYou have entered the following values:");
            for (int i = 0; i < count6; i++)
            {
                Console.WriteLine($"{arr} = Index {i} : {values[i]}");
            }

            string fileData = $"Array Name: {arr}\n";
            for (int i = 0; i < count6; i++)
            {
                fileData += $"Index {i} : {values[i]}\n";
            }
            fileData += "-----------------------------\n";

            // Read old data
            string existingData1 = File.Exists(filePath) ? File.ReadAllText(filePath) : "";
            string[] blocks = existingData1.Split(new string[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

            bool replaced = false;
            for (int i = 0; i < blocks.Length; i++)
            {
                if (blocks[i].StartsWith($"Array Name: {arr}")) // Exact match
                {
                    blocks[i] = fileData.Trim(); // Replace old block
                    replaced = true;
                    break;
                }
            }

            if (replaced)
            {
                existingData1 = string.Join("\n\n", blocks);
                File.WriteAllText(filePath, existingData1);
                Console.WriteLine($"\nArray Name: '{arr}' already exists then Replaced.");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(existingData1))
                    existingData1 += "\n\n";

                existingData1 += fileData.Trim();
                File.WriteAllText(filePath, existingData1);
                Console.WriteLine($"\nArray Name: '{arr}' was new Added.");
            }

            // 🔹 Option to read file
            Console.WriteLine("\nDo you want to Read File (y/n)?");
            string stryes = Console.ReadLine();

            if (stryes.Trim().ToLower() == "y")
            {
                Console.WriteLine($"\nReading from: {filePath}");
                Console.WriteLine(File.ReadAllText(filePath));
            }
            else if (stryes.Trim().ToLower() == "n")
            {
                Console.WriteLine("\nFile reading skipped.");
            }
            else
            {
                Console.WriteLine("\nError: Invalid input.");
            }
        }
    }
}
