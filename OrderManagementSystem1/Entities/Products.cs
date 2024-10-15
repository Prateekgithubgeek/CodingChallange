namespace entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }
        public string Type { get; set; }

        public Product(int id, string name, string description, double price, int quantity, string type)
        {
            ProductId = id;
            ProductName = name;
            Description = description;
            Price = price;
            QuantityInStock = quantity;
            Type = type;
        }
    }
}
