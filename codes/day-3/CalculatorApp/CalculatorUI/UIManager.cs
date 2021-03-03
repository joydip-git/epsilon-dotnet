using CalculationLibrary;
using System;

namespace CalculatorUI
{
    //Utility class
    //you can never create an instance of this class
    //static class can have only static members
    static class UIManager
    {
        static Calculation calculation = new Calculation();

        public static void PrintMenu()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
        }

        public static int GetChoice()
        {
            Console.Write("\nEnter choice[1/2/3/4]: ");
            //string strChoice = Console.ReadLine();
            //int choice = Convert.ToInt32(strChoice);
            //int choice = int.Parse(strChoice);
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public static int GetValue()
        {
            Console.Write("\nEnter Value:");
            int value = int.Parse(Console.ReadLine());
            return value;
        }

        public static void Calculate(int choice)
        {
            int firstValue = GetValue();
            int secondValue = GetValue();

            int result = 0;
            switch (choice)
            {
                case 1:
                    result = calculation.Add(firstValue, secondValue);
                    //concatenation
                    Console.WriteLine("Result of addition of " + firstValue + " and " + secondValue + "is " + result);
                    break;

                case 2:
                    result = calculation.Subtract(firstValue, secondValue);
                    //placeholder
                    Console.WriteLine("Result of subtraction of {0} and {1} is {2}", firstValue, secondValue, result);
                    break;

                case 3:
                    result = calculation.Multiply(firstValue, secondValue);
                    //string interpolation
                    Console.WriteLine($"Result of multiplication of {firstValue} and {secondValue} is {result}");
                    break;

                case 4:
                    result = calculation.Divide(firstValue, secondValue);
                    Console.WriteLine($"Result of division of {firstValue} and {secondValue} is {result}");
                    break;

                default:
                    Console.WriteLine("\nKindly enter proper choice");
                    break;
            }
        }

        public static char ToContinueOrNot()
        {
            Console.Write("\nWould you like to continue?[y/Y/n/N]: ");
            char choice = char.Parse(Console.ReadLine());
            return choice;
        }

        public static char ConvertChoice(char choice)
        {
            if (char.IsUpper(choice))
            {
                char lowerChoice = char.ToLower(choice);
                return lowerChoice;
            }

            return choice;
        }
    }
}
