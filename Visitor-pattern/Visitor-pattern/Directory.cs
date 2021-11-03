using System;
using System.Collections;
using System.Collections.Generic;

namespace Visitor_pattern
{
    public class Directory : Entry, IEnumerable
    {
        private string name;
        private List<Entry> directory = new List<Entry>();
        public Directory(string name)
        {
            this.name = name;
        }
        public override string GetName()
        {
            return this.name;
        }

        public override int GetSize()
        {
            int size = 0;
            var it = directory.GetEnumerator();
            while(it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                size += entry.GetSize();
            }
            return size;
        }

        public new Entry Add(Entry entry)
        {
            directory.Add(entry);
            return this;
        }

        public override void PrintList(string prefix)
        {
            Console.WriteLine($"{prefix}/{this}");
            var it = directory.GetEnumerator();
            while(it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                var pre = $"{prefix}/{name}";
                entry.PrintList(pre);
            }
        }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }

        public IEnumerator GetEnumerator()
        {
            return directory.GetEnumerator();
        }
    }
}
