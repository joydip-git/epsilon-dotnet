using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDataAccess.Utility
{
    public static class Procedures
    {
        //const keyword is used with data members too, NOT ONLY with local variables
        //const data members must be assigned value immediately
        //the value is unchangable throughout the application
        //hence there is no chance of manipulation of data so you can easily declared const data members with public access specifier
        //const members are by default static
        //access them with class name
        public const string GETPRODUCTS = "GetProducts";
        public const string GETPRODUCT = "GetProductById";
        public const string ADDPRODUCT = "InsertProduct";
    }
}
