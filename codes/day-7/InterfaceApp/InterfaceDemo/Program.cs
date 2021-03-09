using System.Security.Cryptography.X509Certificates;
using System;

namespace InterfaceDemo
{
    class Program
    {
        static void PrintMenu()
        {
            System.Console.WriteLine("1. Database");
            System.Console.WriteLine("2. File");
        }
        static int GetChoice()
        {
            System.Console.Write("\nEnter Choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }
        //return type is interface (pure abstract class)
        static IDataAccess Create(int choice)
        {
            IDataAccess dataAccess = null;
            switch (choice)
            {
                case 1:
                    dataAccess = new DatabaseDataAccess();
                    break;

                case 2:
                    dataAccess = new FileDataAccess();
                    break;

                default:
                    break;
            }
            return dataAccess;
        }
        static void Main()
        {
            PrintMenu();
            int choice = GetChoice();
            IDataAccess dataAccess = Create(choice);
            dataAccess.GetData();
            System.Console.WriteLine(dataAccess.Data);

        }
    }
}
