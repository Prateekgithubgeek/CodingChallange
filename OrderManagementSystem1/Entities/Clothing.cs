namespace entity
{
    public class Clothing : Product
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public Clothing(int id, string name, string description, double price, int quantity, string size, string color)
            : base(id, name, description, price, quantity, "Clothing")
        {
            Size = size;
            Color = color;
        }
    }
}
