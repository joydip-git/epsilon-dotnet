using System;

namespace ProductManagementSystem.Entities
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId, string productName, string description, decimal price)
        {
            ProductId = productId;
            ProductName = productName;
            Description = description;
            Price = price;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Name:{ProductName}, Id:{ProductId}, Price:{Price}, Description:{Description}";
        }
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Product)
                {
                    Product other = obj as Product;
                    if (this == other)
                        return true;

                    if (!this.ProductId.Equals(other.ProductId))
                        return false;

                    return true;
                }
                else
                    throw new ArgumentException("pass only product type");
            }
            else
                throw new NullReferenceException("null reference passed");
        }
        public override int GetHashCode()
        {
            return this.ProductId.GetHashCode();
        }
    }
}
