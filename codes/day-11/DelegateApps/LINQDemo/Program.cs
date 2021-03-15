using System;
using System.Collections.Generic;
using System.Linq; //Language Integrated Query (C# 3.0)

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //source of data
            List<int> numbers = new List<int> { 1, 3, 4, 2, 7, 5, 8, 0, 6, 9 };

            //Method query synatx
            numbers
                .Where((num) => num % 2 == 0)
                .OrderByDescending(num => num)
                .Take<int>(3)
                .ToList<int>()
                .ForEach(num => Console.WriteLine(num));

            //query operator syntax
            var query = from num in numbers
                        where num % 2 == 0
                        orderby num descending
                        select num;

            query.Take<int>(3).ToList<int>().ForEach(num => Console.WriteLine(num));

            /*
            //operation to be performed on that source of data
            //1. filter even numbers
            Func<int, bool> evenLogic = (num) => num % 2 == 0;
            IEnumerable<int> evenList = numbers.Where(evenLogic);

            //List<int> evenList = new List<int>();
            //foreach (int item in numbers)
            //{
            //    if (item % 2 == 0)
            //    {
            //        evenList.Add(item);
            //    }
            //}

            //2. sort the list in descending

            Func<int, int> ascendingLogic = (num) => num;
            IOrderedEnumerable<int> sortedEvenList = evenList.OrderByDescending(ascendingLogic);

            
            //List<int> sortedEvenList = new List<int>();
            //foreach (int item in evenList)
            //{
            //    sortedEvenList.Add(item);
            //}
            //for (int i = 0; i < sortedEvenList.Count; i++)
            //{
            //    for (int j = i+1; j < sortedEvenList.Count; j++)
            //    {
            //        int temp = 0;
            //        if (sortedEvenList[i] < sortedEvenList[j])
            //        {
            //            temp = sortedEvenList[i];
            //            sortedEvenList[i] = sortedEvenList[j];
            //            sortedEvenList[j] = temp;
            //        }
            //    }
            //}
            //foreach (int item in evenList)
            //{
            //    sortedEvenList.Add(item);
            //}
           

            //3. pick only n 
            int count = 4;
            IEnumerable<int> final = sortedEvenList.Take<int>(count);

            //List<int> final = new List<int>();
            //for (int i = 0; i < count; i++)
            //{
            //    final.Add(sortedEvenList[i]);
            //}

            //4. display
            Action<int> showDel = (num) => Console.WriteLine(num);
            final.ToList<int>().ForEach(showDel);
            //foreach (int item in final)
            //{
            //    Console.WriteLine(item);
            //}
            */
        }
    }
}
