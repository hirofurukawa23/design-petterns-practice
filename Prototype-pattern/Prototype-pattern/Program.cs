using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            UnderlinePen uPen = new UnderlinePen('~');
            MessageBox mbox = new MessageBox('*');
            MessageBox sbox = new MessageBox('/');

            manager.Register("strong message", uPen);
            manager.Register("warning box", mbox);
            manager.Register("slash box", sbox);

            IProduct p1 = manager.Create("strong message");
            p1.Use("Hello, World");
            IProduct p2 = manager.Create("warning box");
            p2.Use("Hello, World");
            IProduct p3 = manager.Create("slash box");
            p3.Use("Hello, World");

            Console.ReadLine();
        }
    }
}
