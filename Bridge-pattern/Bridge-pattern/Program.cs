using System;

namespace Bridge_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Display d1 = new Display(new StringDisplayImpl("Hello, Japan."));
            Display d2 = new Display(new StringDisplayImpl("Hello, World."));
            CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello, Universe."));

            d1.DisplayString();
            d2.DisplayString();
            d3.DisplayString();
            d3.MultiDisplay(5);

            Console.ReadLine();
        }
    }
}
