using System;

namespace RefandOutApp
{
    class Program
    {
        static void Swipe(int x, ref int y, out int z)
        {
            x = 11;
            y = 22;
            z = 33;
            System.Console.WriteLine($"{x} and {y} and {z}");
        }
        static void Main()
        {
            int a = 10;
            int b = 20;
            int c;
            //System.Console.WriteLine($"{a} and {b} and {c}");
            //you must assign a value to c in the Swipe function
            Swipe(a, ref b, out c);
            System.Console.WriteLine($"{a} and {b} and {c}");

            System.Console.Write("enter dob in mm/dd/yyyy format: ");
            string dobStr = Console.ReadLine();

            DateTime dob;
            bool possible = DateTime.TryParse(dobStr, out dob);

            if (possible)
                System.Console.WriteLine(dob);
            else
                Console.WriteLine($"Please enter dob in poper format. {dob}");
        }
    }
}
