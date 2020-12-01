using FactoryMethod.Console.Creators.Abstract;
using FactoryMethod.Console.Products;
using FactoryMethod.Console.Products.Abstract;

namespace FactoryMethod.Console.Creators
{
    public class Truck : TransportBase
    {
        public override IProduct DeliveProduct()
        {
            return new Petrol();
        }
    }
}
