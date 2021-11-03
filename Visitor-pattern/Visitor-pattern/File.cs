using System;

namespace Visitor_pattern
{
    public class File : Entry
    {
        private string name;
        private int size;
        public File(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        public override string GetName()
        {
            return name;
        }

        public override int GetSize()
        {
            return size;
        }

        public override void PrintList(string prefix)
        {
            Console.WriteLine($"{ prefix }/{ this }");
        }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
