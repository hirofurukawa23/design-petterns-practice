using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = new List<string>()
            {
                "program end",
                "program go end",
                "program go right go right go right go right end",
                "program repeat 4 go right end end",
                "program repeat 4 repeat 4 repeat 3 go right go left end right end end"
            };
            foreach(var l in lines)
            {
                Console.WriteLine($"text = {l}");
                Node node = new ProgramNode();
                node.Parse(new Context(l));
                Console.WriteLine($"node = {node}");
            }
            Console.ReadLine();
        }
    }
}
