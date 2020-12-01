using FactoryMethod.Console.Products.Abstract;

namespace FactoryMethod.Console.Products
{
    // For simplicity, I did not implement products in different ways.
    public class Petrol : IProduct
    {
        public string Name { get; set; }

        public Petrol(string name = "Petrol")
        {
            Name = name;
        }

        public string GetProduct()
        {
            return Name;
        }
    }
}
