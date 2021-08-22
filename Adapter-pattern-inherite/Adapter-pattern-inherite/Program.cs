using System;

namespace Adapter_pattern_inherite
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintStrong();

            Console.ReadLine();
        }
    }
}
