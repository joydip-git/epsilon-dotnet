using System;
using CalculationLibrary;
using CalculationLibraryExtended;
using System.Collections.Generic;
using System.Linq;

using DataAccess.Contracts;
using DataAccess.File;
using DataAccess.Database;
using DataAccess.Contracts.Extension;
using ProductLibrary;

namespace ExtensionMethodUse
{
    class Program
    {
        static void Add(int first, long second, int third)
        {

        }
        //static void CalculateArea(params int[] a)

        //optional arguments (with default value)
        //static void CalculateArea(int choice, int a, int b = 0, int c = 0, int d = 0, int e = 0, int f = 0, int g = 0, int h = 0, int x)
        static void CalculateArea(int choice, int a, int b = 0, int c = 0, int d = 0, int e = 0, int f = 0, int g = 0, int h = 0)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine(a * a);
                    break;


                default:
                    break;
            }

        }
        static void Main()
        {
            //CalculateArea(12, 0, 0, 0, 0, 0, 0, 0);
            //CalculateArea(1, 12, x: 134);
            CalculateArea(1, 12);
            CalculateArea(a: 12, choice: 1, d: 123);

            //Add(12, 1234567890, 123);
            //named arguments
            Add(second: 1234567890, first: 12, third: 123);

            Calculation calculation = new Calculation();
            Console.WriteLine(calculation.Add(12, 3));
            Console.WriteLine(calculation.Multiply(12, 3));

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Where(n => n % 2 == 0);

            ProductFileDataAccess access = new ProductFileDataAccess();
            access.SetPath("");

            ProductDatabaseDataAccess database = new ProductDatabaseDataAccess();
            database.SetPath("");

            IDataAccess<Product> iAccess = access;
            iAccess.SetPath("");

            PersonDatabaseDataAccess pda = new PersonDatabaseDataAccess();
            pda.SetPath("");

            //var d = 12;
            dynamic d = "abcd, def.";
            d = 'a';
           // d.Split(',', '.');
        }
    }
}
