namespace ProductLibrary
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId, string productName, decimal price, string description)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Description = description;
        }
        //auto-implemented properties
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name:{ProductName}";
        }
    }
}
