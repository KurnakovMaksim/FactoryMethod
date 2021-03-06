﻿using FactoryMethod.Console.Products.Abstract;

namespace FactoryMethod.Console.Creators.Abstract
{
    public abstract class TransportBase : ITransport
    {
        public abstract IProduct DeliveProduct();

        public string PrintMessageAboutDelive()
        {
            IProduct deliveProduct = DeliveProduct();

            string result = $"Product {deliveProduct.GetProduct()} gotten, hooray!";

            return result;
        }
    }
}
