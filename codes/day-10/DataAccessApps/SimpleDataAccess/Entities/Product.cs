namespace SimpleDataAccess.Entities
{
    public class Product
    {
        private int productId;
        private string productName;
        private decimal price;
        private string description;

        public Product()
        {

        }

        public Product(int productId, string productName, decimal price, string description)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.description = description;
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        public decimal Price
        {
            get { return price; }
            set { price = value; }
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

        public override string ToString()
        {
            return $"{this.productName}\t{this.productId}\t{this.description}\t{this.price}";
        }
    }
}
