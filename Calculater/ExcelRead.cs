using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelCalculater
{
    public class ExcelRead
    {
        public void EXCELREAD()
        {
            string filePath2 = @"C:\\Users\\jdhtrainee9\\Documents\\Employee.xlsx";

            if (!File.Exists(filePath2))
            {
                Console.WriteLine("Error: File not found!");
                
            }

            try
            {

                var workbook = new ClosedXML.Excel.XLWorkbook(filePath2);
                var worksheet = workbook.Worksheet(1);
                int lastRow = worksheet.LastRowUsed().RowNumber(); // find last empty row


                int empId;
                while (true)
                {
                    Console.Write("Enter Employee ID: ");
                    if (int.TryParse(Console.ReadLine(), out empId))
                    {
                        // check duplicate in column 1
                        bool exists = false;
                        for (int r = 2; r <= lastRow; r++)
                        {
                            if (worksheet.Cell(r, 1).GetValue<int>() == empId)
                            {
                                exists = true;
                                break;
                            }
                        }
                        if (!exists) break;
                        Console.WriteLine("Error: Employee ID already exists!");
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid Employee ID. Please enter a number.");
                    }
                }


                string name;
                do
                {
                    Console.Write("Enter Employee Name: ");
                    name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Error: Name cannot be empty!");
                    }
                } while (string.IsNullOrWhiteSpace(name));


                string dept;
                do
                {
                    Console.Write("Enter Department: ");
                    dept = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(dept))
                    {
                        Console.WriteLine("Error: Department cannot be empty!");
                    }
                } while (string.IsNullOrWhiteSpace(dept));


                string mobile;
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^[0-9]{10}$");

                while (true)
                {
                    Console.Write("Enter Mobile Number (10 digits): ");
                    mobile = Console.ReadLine();

                    if (!regex.IsMatch(mobile))
                    {
                        Console.WriteLine("Error: Invalid Mobile Number! Please enter exactly 10 digits.");
                        continue;
                    }


                    bool exists = false;
                    for (int r = 2; r <= lastRow; r++)
                    {
                        if (worksheet.Cell(r, 4).GetValue<string>() == mobile)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists) break;
                    Console.WriteLine("Error: Mobile Number already exists!");
                }


                double salary;
                while (true)
                {
                    Console.Write("Enter Salary: ");
                    if (double.TryParse(Console.ReadLine(), out salary))
                        break;
                    Console.WriteLine("Error: Invalid Salary. Enter numeric value.");
                }


                int newRow = worksheet.LastRowUsed().RowNumber() + 1;
                worksheet.Cell(newRow, 1).Value = empId;
                worksheet.Cell(newRow, 2).Value = name;
                worksheet.Cell(newRow, 3).Value = dept;
                worksheet.Cell(newRow, 4).Value = mobile;
                worksheet.Cell(newRow, 5).Value = salary;

                workbook.Save();
                Console.WriteLine("\nData written successfully to Excel file!");


                Console.Write("\nDo you want to read the Excel file? (Y/N): ");
                string choice12 = Console.ReadLine().Trim().ToUpper();

                if (choice12 == "Y")
                {
                    int lastRow2 = worksheet.LastRowUsed().RowNumber();
                    int lastCol = worksheet.LastColumnUsed().ColumnNumber();

                    Console.WriteLine("\nExcel File Data:");
                    for (int r = 1; r <= lastRow2; r++)
                    {
                        for (int c = 1; c <= lastCol; c++)
                        {
                            Console.Write(worksheet.Cell(r, c).GetValue<string>() + "\t");
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while writing Excel file: " + ex.Message);
            }
        }
    }
}
