using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main()
        {
            /*
            //<data-type>[] <arr-ref-var> = new <data-type>[3];
            //Array intArr = new Array(int,3);
            int[] intArr = new int[3];
            // intArr[0] = 10;
            // intArr[1] = 20;
            // intArr[2] = 30;
            //System.Console.WriteLine(intArr.GetType().Name);
            for (int i = 0; i < intArr.Length; i++)
            {
                System.Console.Write($"enter value at intArr[{i}]: ");
                intArr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int item in intArr)
            {
                //Console.WriteLine($"value at intArr[{i}]:{item}");
                Console.WriteLine($"{item}");
            }

            string[] names = new string[] { "anil", "sunil", "joy" };
            foreach (string name in names)
            {
                System.Console.WriteLine(name);
            }
            */
            System.Console.Write("\n\nRows: ");
            int rowCount = int.Parse(Console.ReadLine());

            System.Console.Write("Number of elements in every row: ");
            int elementCount = int.Parse(Console.ReadLine());

            int[,] twoDimIntArr = new int[rowCount, elementCount];

            Console.WriteLine($"Rank: {twoDimIntArr.Rank}");
            Console.WriteLine($"No of rows is {twoDimIntArr.GetLength(0)}");
            Console.WriteLine($"No of columns is {twoDimIntArr.GetLength(1)}");

            for (int i = 0; i < twoDimIntArr.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimIntArr.GetLength(1); j++)
                {
                    System.Console.Write($"enter value at twoDimIntArr[{i},{j}]: ");
                    twoDimIntArr[i, j] = int.Parse(Console.ReadLine());
                }
                System.Console.WriteLine("\n");
            }
            System.Console.WriteLine("\n\n");
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < elementCount; j++)
                {
                    System.Console.WriteLine($"value at twoDimIntArr[{i},{j}]: {twoDimIntArr[i, j]}");
                }
                System.Console.WriteLine("\n");
            }
        }
    }
}
