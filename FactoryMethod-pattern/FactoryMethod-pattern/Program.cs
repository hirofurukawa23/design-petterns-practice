using System;

namespace FactoryMethod_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new IDCardFactory();

            Product card1 = factory.CreateProduct("John Doe1");
            Product card2 = factory.CreateProduct("John Doe2");
            Product card3 = factory.CreateProduct("John Doe3");

            card1.Use();
            card2.Use();
            card3.Use();

            Console.ReadLine();
        }
    }
}
