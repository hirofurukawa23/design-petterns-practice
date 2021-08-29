using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Usage();

            var input = Console.ReadLine();
            if (input.Equals("plain"))
            {
                var textbuilder = new TextBuilder();
                var director = new Director(textbuilder);
                director.Construct();

                var result = textbuilder.GetResult();
                Console.WriteLine(result);
            }
            else if (input.Equals("html"))
            {
                var htmlbuilder = new HTMLBuilder();
                var director = new Director(htmlbuilder);
                director.Construct();

                var result = htmlbuilder.GetResult();
                Console.WriteLine($"{ result }が作成されました。");
            }

            Console.ReadLine();
        }

        private static void Usage()
        {
            Console.WriteLine("usage : C# Main plain");
            Console.WriteLine("usage : C# Main html");
        }
    }
}
