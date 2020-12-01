using FactoryMethod.Console.Creators;
using FactoryMethod.Console.Creators.Abstract;

namespace FactoryMethod.Console.Clients
{
    class Client
    {
        public void Main()
        {
            System.Console.WriteLine("Petrol in transit...");
            ClientMethod(new Truck());

            System.Console.WriteLine("Fish in transit...");
            ClientMethod(new Ship());
        }

        public void ClientMethod(TransportBase transportBase)
        {
            System.Console.WriteLine(transportBase.PrintMessageAboutDelive());
        }
    }
}
