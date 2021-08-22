using System;

namespace TemplateMethod_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var d1 = new CharDisplay('H');
            var d2 = new StringDisplay("Hello, World.");
            var d3 = new StringDisplay("こんにちは。");

            d1.Display();
            d2.Display();
            d3.Display();

            Console.ReadLine();
        }
    }
}
