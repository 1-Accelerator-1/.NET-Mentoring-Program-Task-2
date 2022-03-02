namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (obj.GetType() != typeof(Product))
            {
                return false;
            }

            var product = (Product)obj;
            return (Name == product.Name) && (Price == product.Price);
        }
    }
}
