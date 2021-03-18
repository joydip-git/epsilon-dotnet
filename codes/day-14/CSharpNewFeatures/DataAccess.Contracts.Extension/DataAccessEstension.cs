using ProductLibrary;
using System;

namespace DataAccess.Contracts.Extension
{
    //public static class DataAccessEstension
    //{
    //    public static void SetPath(this IDataAccess<Product> dataAccess, string path)
    //    {
    //        //dataAccess.
    //        //code
    //        Console.WriteLine($"Path: {path}");
    //    }
    //}
    public static class DataAccessEstension
    {
        public static void SetPath<T>(this IDataAccess<T> dataAccess, string path)
        {
            //dataAccess.
            //code
            Console.WriteLine($"Path: {path}");
        }
    }
}
