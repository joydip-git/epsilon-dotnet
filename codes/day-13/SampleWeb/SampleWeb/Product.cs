using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWeb
{
    public class Product
    {
        private int productId;
        private string productName;
        private string description;
        private decimal price;
        
        public Product()
        {

        }

        public Product(int productId, string productName, string description, decimal price)
        {
            this.productId = productId;
            this.productName = productName;
            this.description = description;
            this.price = price;
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        //public override string ToString()
        //{
        //    return $"Name";
        //}
    }
}