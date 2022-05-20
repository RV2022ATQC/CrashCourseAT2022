namespace _301
{
    class Product
    {
        static int counter = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(double price, string name)
        {
            Price = price;
            Name = name;
            Id = counter;
            counter++;
        }
    }
}
