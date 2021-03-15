using System;
using System.Collections.Generic;

namespace Implementation
{
    delegate bool FilterLogic(int x);

    //class Logic
    //{
    //    public static bool IsEven(int num)
    //    {
    //        return num % 2 == 0;
    //    }
    //    public static bool IsOdd(int num)
    //    {
    //        return num % 2 != 0;
    //    }
    //    public static bool IsGreatherThanFive(int num)
    //    {
    //        return num > 5;
    //    }
    //}
    class Program
    {
        static List<int> Filter(List<int> input, FilterLogic filterLogic)
        {
            List<int> output = new List<int>();
            foreach (int item in input)
            {
                if (filterLogic(item))
                {
                    output.Add(item);
                }
            }
            return output;
        }
        static void Main()
        {
            //1. source of data
            List<int> numbers = new List<int> { 1, 3, 4, 2, 7, 5, 8, 0, 6, 9 };

            //2. logic: filter this list to produce another list containing only even numbers fron the original list

            //delegate pointing/referring a (well-defined) method
            //FilterLogic evenLogic = new FilterLogic(Logic.IsEven);
            //List<int> result = Filter(numbers, evenLogic);

            //FilterLogic lessThanFiveLogic = public bool IsLessThanFive(int num) {
            //    return num < 5;
            //};
            //delegate referring an anonymous method
            //FilterLogic lessThanFiveLogic = delegate (int num)
            //{
            //    return num < 5;
            //};
            FilterLogic lessThanFiveLogic = num => num < 5;
            FilterLogic evenLogic = num => num % 2 == 0;
            FilterLogic oddLogic = num => num % 2 != 0;
            FilterLogic greaterThanFiveLogic = num => num > 5;

            List<int> result = Filter(numbers, lessThanFiveLogic);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
