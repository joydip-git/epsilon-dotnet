using SimpleDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SimpleDataAccess.BL
{
    public class ProductComparison : IComparer<Product>
    {
        private int sortChoice;
        public ProductComparison()
        {

        }
        public ProductComparison(int choice)
        {
            sortChoice = choice;
        }
        public int Compare([AllowNull] Product x, [AllowNull] Product y)
        {
            int result = 0;
            switch (sortChoice)
            {
                case 1:
                    result = x.ProductName.CompareTo(y.ProductName);
                    break;

                case 2:
                    result = x.Price.CompareTo(y.Price);
                    break;

                default:
                    result = x.ProductId.CompareTo(y.ProductId);
                    break;
            }
            return result;
        }
    }
}
