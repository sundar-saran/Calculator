using ADDCalculater;
using SUBCalculater;
using MULTICalculater;
using DIVCalculater;
using MODCalculater;
using ARRCalculater;
using ListCalculater;
using ExcelCalculater;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.IO;
using System.Text.Json;


namespace hello
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to Calculator");
                Console.WriteLine("\nPress key 1 to 9 for Operation: ");

                Console.WriteLine("- For Addition Press 1.\n- For Substraction Press 2. \n- For Multiplication Press 3. \n- For Division Press 4. \n- For Modulus Press 5. \n- For Array Press 6.\n- For List Press 7.\n- For Excel Press 8.\n- For Exit Press 9.");


                Addition ADDMethodCall = new Addition();
                Substraction SUBMethodCall = new Substraction();
                Multiplication MULTIMethodCall = new Multiplication();
                Divide DIVMethodCall = new Divide();
                Modules MODMethodCall = new Modules();
                Array1 ARRMethodCall = new Array1();
                List LISTMethodCall = new List();
                ExcelRead ExcelMethodCall = new ExcelRead();

                int ope;
                while (true)
                {
                    Console.Write("\nPlease Press/Enter Key: ");
                    try
                    {
                        ope = int.Parse(Console.ReadLine());
                        if (ope >= 1 && ope <= 9) break;
                        else Console.WriteLine("Error: Invalid key! Please enter between 1 and 7.");
                    }
                    catch
                    {
                        Console.WriteLine("Error: Invalid key, only number is allowed.");
                    }
                }

                if (ope == 9)
                {
                    Console.WriteLine("Thanks, Exiting to calculator... Goodbye!");
                    break;
                }

                switch (ope)
                {
                    case 1: // ADDITION
                        ADDMethodCall.ADDITION();
                        break;

                    case 2: // SUBTRACTION
                        SUBMethodCall.SUBTRACTION();
                        break;

                    case 3: // MULTIPLICATION
                        MULTIMethodCall.MULTIPALICATION();
                        break;

                    case 4: // DIVISION
                        DIVMethodCall.DIVIDE();
                        break;

                    case 5: // MODULUS
                        MODMethodCall.MODULS();
                        break;

                    case 6: // ARRAY
                        ARRMethodCall.ARRAY();
                        break;

                    case 7: // List
                        LISTMethodCall.LIST();
                        break;

                    case 8: // Excel File
                        ExcelMethodCall.EXCELREAD();
                        break;
                }
                Console.WriteLine("\nThanks for using the calculator. Your calculation is complete.");
                Console.ReadLine();
            }
        }
    }
}