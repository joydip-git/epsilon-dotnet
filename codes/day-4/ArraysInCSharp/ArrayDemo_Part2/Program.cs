using System;

namespace ArrayDemo_Part2
{
    class Program
    {
        static void Main()
        {
            //int[] arrayFirst = new int[] { 1, 2, 3 };
            //int[] arraySecond = new int[] { 4, 5 };
            //int[] arrayThird = new int[] { 6, 7, 8, 9, 0 };

            int arrayCount = GetArrayCount();

            int[][] jagged = new int[arrayCount][];
            //jagged[0] = arrayFirst;
            //jagged[1] = arraySecond;
            //jagged[2] = arrayThird;

            //1. create as many arrays of similar nature as that of the arrayCount
            //2. store values in those individual arrays
            //3. save those individual arrays into a certain index position of the jagged array

            PopulateJaggedArray(jagged);
            Console.WriteLine("\n");
            DisplayJaggedArrayValues(jagged);
        }

        private static void DisplayJaggedArrayValues(int[][] jagged)
        {
            for (int i = 0; i < jagged.Length; i++)
            {
                //int[] arr = jagged[i];
                //for (int j = 0; j < arr.Length; j++)
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    //Console.WriteLine($"value at jagged[{i}][{j}]: {arr[j]}");
                    Console.WriteLine($"value at jagged[{i}][{j}]: {jagged[i][j]}");
                }
                Console.WriteLine("\n");
            }
        }

        private static void PopulateJaggedArray(int[][] jagged)
        {
            for (int count = 0; count < jagged.Length; count++)
            {
                int elements = GetNumberOfElements(count);
                int[] newArray = new int[elements];
                Console.WriteLine("\n");
                EnterValuesInTheArray(newArray);
                jagged[count] = newArray;
            }
        }

        private static void EnterValuesInTheArray(int[] newArray)
        {
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write($"Enter value at newArray[{i}]: ");
                newArray[i] = int.Parse(Console.ReadLine());
            }
        }

        private static int GetNumberOfElements(int count)
        {
            Console.Write($"\nHow many elements in the array#{(count + 1)}? ");
            int elements = int.Parse(Console.ReadLine());
            return elements;
        }

        private static int GetArrayCount()
        {
            Console.Write("How many arrays: ");
            int arrayCount = int.Parse(Console.ReadLine());
            return arrayCount;
        }
    }
}
