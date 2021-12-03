namespace WpfBindingProducts
{
    public class Products
    {
        public string Name { set; get; } 
        public double Price { set; get; }
        public double Amount { set; get; }
        public double Really { set; get; }
        public long Barcode { set; get; }
        public bool Bought { set; get; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
