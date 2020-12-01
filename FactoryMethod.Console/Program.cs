using FactoryMethod.Console.Clients;
using FactoryMethod.Console.Creators;
using FactoryMethod.Console.Creators.Abstract;

namespace FactoryMethod.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
            System.Console.ReadLine();
        }
    }
}
