using System;
using System.Collections.Generic;
using System.Linq;

namespace Implementation
{
    //delegate bool FilterLogic(int x);
    //delegate bool FilterLogic<in TInput>(TInput x);

    //built-in
    //public delegate bool Predicate<in T>(T obj);   

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
        //static List<T> Filter<T>(List<T> input, FilterLogic<T> filterLogic)
        static List<T> Filter<T>(List<T> input, Predicate<T> filterLogic)
        {
            List<T> output = new List<T>();
            foreach (T item in input)
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
            Filter<int>(numbers, (a) => a < 5).ForEach(a => Console.WriteLine(a));


            //2. logic: filter this list to produce another list containing only even numbers fron the original list

            //delegate pointing/referring a (well-defined) method
            //FilterLogic evenLogic = new FilterLogic(Logic.IsEven);
            //List<int> result = Filter(numbers, evenLogic);

            //FilterLogic lessThanFiveLogic = public bool IsLessThanFive(int num) {
            //    return num < 5;
            //};

            //delegate referring an anonymous method (C# v2.0)
            //FilterLogic lessThanFiveLogic = delegate (int num)
            //{
            //    return num < 5;
            //};

            //Lambda (C# 3.0)

            //Predicate<int>
            //Func<int,bool>
            //FilterLogic<int> lessThanFiveLogic = num => num < 5;
            //FilterLogic<int> evenLogic = num => num % 2 == 0;
            //FilterLogic<int> oddLogic = num => num % 2 != 0;
            //FilterLogic<int> greaterThanFiveLogic = num => num > 5;

            /*
            Predicate<int> lessThanFiveLogic = num => num < 5;
            Predicate<int> evenLogic = num => num % 2 == 0;
            Predicate<int> oddLogic = num => num % 2 != 0;
            Predicate<int> greaterThanFiveLogic = num => num > 5;

            List<int> result = Filter<int>(numbers, lessThanFiveLogic);
            //    foreach (int item in result)
            //    {
            //        Console.WriteLine(item);
            //    }

            Action<int> printDel = (num) => Console.WriteLine(num);
            result.ForEach(printDel);
            */

        }
    }
}
