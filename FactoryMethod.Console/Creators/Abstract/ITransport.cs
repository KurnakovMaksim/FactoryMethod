using FactoryMethod.Console.Products.Abstract;

namespace FactoryMethod.Console.Creators.Abstract
{
    public interface ITransport
    {
        IProduct DeliveProduct();
        string PrintMessageAboutDelive();
    }
}
