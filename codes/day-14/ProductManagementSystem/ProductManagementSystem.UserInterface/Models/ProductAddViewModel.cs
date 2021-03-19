using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementSystem.UserInterface.Models
{
    public class ProductAddViewModel
    {
        public ProductAddViewModel()
        {

        }
        public ProductAddViewModel(int productId, string productName, string description, decimal price)
        {
            Id = productId;
            Name = productName;
            Description = description;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}, Id:{Id}, Price:{Price}, Description:{Description}";
        }
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is ProductAddViewModel)
                {
                    ProductAddViewModel other = obj as ProductAddViewModel;
                    if (this == other)
                        return true;

                    if (!this.Id.Equals(other.Id))
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
            return this.Id.GetHashCode();
        }
    }
}
