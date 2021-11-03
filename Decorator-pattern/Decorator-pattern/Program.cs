using System;

namespace Decorator_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Display d1 = new StringDisplay("Hello, world");
            Display d2 = new SideBorder(d1, '#');
            Display d3 = new FullBorder(d2);
            d1.Show();
            d2.Show();
            d3.Show();
            Display d4 = new SideBorder
            (
                new FullBorder
                (
                    new FullBorder
                    (
                        new SideBorder
                        (
                            new FullBorder(new StringDisplay("こんにちは。")), 
                            '*'
                        )
                    )
                ), 
                '/'
            );
            d4.Show();
            Console.ReadLine();
        }
    }
}
