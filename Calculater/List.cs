using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCalculater
{
    public class List
    {
        public void LIST() 
        {
            Console.WriteLine("Welcome,\nYou are performing List");

            Console.WriteLine("\nChoose the data type for your list:");
            Console.WriteLine("- For int press 1.");
            Console.WriteLine("- For double press 2.");
            Console.WriteLine("- For string press 3.");

            int choice;
            while (true)
            {
                Console.Write("\nPlease Enter Your Choice: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice >= 1 && choice <= 3) break;
                    else Console.WriteLine("Error: Invalid choice! Please enter between 1 and 3.");
                }
                catch
                {
                    Console.WriteLine("Error: Invalid choice, only number is allowed.");
                }
            }

            Console.Write("Enter List name: ");
            string listName = Console.ReadLine();

            string filePath1 = "local_storage_list.txt";

            List<object> finalList = new List<object>();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nEnter integer values (type 'stop' to end list):");
                    while (true)
                    {
                        Console.Write($"Index {finalList.Count}: ");
                        string input = Console.ReadLine();
                        if (input.Trim().ToLower() == "stop") break;

                        if (int.TryParse(input, out int val))
                            finalList.Add(val);
                        else
                            Console.WriteLine("Error: Invalid integer, try again.");
                    }
                    break;

                case 2:
                    Console.WriteLine("\nEnter double values (type 'stop' to end list):");
                    while (true)
                    {
                        Console.Write($"Index {finalList.Count}: ");
                        string input = Console.ReadLine();
                        if (input.Trim().ToLower() == "stop") break;

                        if (double.TryParse(input, out double val))
                            finalList.Add(val);
                        else
                            Console.WriteLine("Error: Invalid double, try again.");
                    }
                    break;

                case 3:
                    Console.WriteLine("\nEnter string values (type 'stop' to end list):");
                    while (true)
                    {
                        Console.Write($"Index {finalList.Count}: ");
                        string input = Console.ReadLine();
                        if (input.Trim().ToLower() == "stop") break;

                        finalList.Add(input);
                    }
                    break;
            }

            // Show entered list
            Console.WriteLine($"\nList name: {listName}");
            for (int i = 0; i < finalList.Count; i++)
            {
                Console.WriteLine($"Index {i} : {finalList[i]}");
            }

            // Build block text
            string listData = $"List Name: {listName}\n";
            for (int i = 0; i < finalList.Count; i++)
            {
                listData += $"Index {i} : {finalList[i]}\n";
            }
            listData += "-----------------------------\n";


            string existingData = File.Exists(filePath1) ? File.ReadAllText(filePath1) : "";
            string[] blocks1 = existingData.Split(new string[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

            bool replaced1 = false;
            for (int i = 0; i < blocks1.Length; i++)
            {
                if (blocks1[i].StartsWith($"List Name: {listName}")) // Exact match check
                {
                    blocks1[i] = listData.Trim(); // Replace old block
                    replaced1 = true;
                    break;
                }
            }

            if (replaced1)
            {
                existingData = string.Join("\n\n", blocks1);
                File.WriteAllText(filePath1, existingData);
                Console.WriteLine($"\nList name: '{listName}' already exists, Replaced.");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(existingData))
                    existingData += "\n\n";

                existingData += listData.Trim();
                File.WriteAllText(filePath1, existingData);
                Console.WriteLine($"\nList Name: '{listName}' was new Added.");
            }

            // Ask if user wants to read file
            Console.WriteLine("\nDo you want to Read File (y/n)?");
            string readChoice = Console.ReadLine();

            if (readChoice.Trim().ToLower() == "y")
            {
                Console.WriteLine($"\nReading from: {filePath1}");
                Console.WriteLine(File.ReadAllText(filePath1));
            }
            else if (readChoice.Trim().ToLower() == "n")
            {

            }
            else
            {
                Console.WriteLine($"\nPlease Enter vailid input.");
            }


        }
    }
}
