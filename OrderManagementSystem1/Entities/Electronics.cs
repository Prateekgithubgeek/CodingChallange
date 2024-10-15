namespace entity
{
    public class Electronics : Product
    {
        public string Brand { get; set; }
        public int WarrantyPeriod { get; set; }

        public Electronics(int id, string name, string description, double price, int quantity, string brand, int warranty)
            : base(id, name, description, price, quantity, "Electronics")
        {
            Brand = brand;
            WarrantyPeriod = warranty;
        }
    }
}
