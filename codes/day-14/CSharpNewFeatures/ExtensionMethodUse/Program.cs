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
        static void Main()
        {
            Calculation calculation = new Calculation();
            Console.WriteLine(calculation.Add(12,3));
            Console.WriteLine(calculation.Multiply(12,3));

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
        }
    }
}
