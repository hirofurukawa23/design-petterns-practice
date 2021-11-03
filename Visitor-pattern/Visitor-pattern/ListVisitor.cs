using System;

namespace Visitor_pattern
{
    public class ListVisitor : Visitor
    {
        private string currentDir = "";
        public override void Visit(File file)
        {
            Console.WriteLine($"{currentDir}/{file}");
        }

        public override void Visit(Directory directory)
        {
            Console.WriteLine($"{currentDir}/{directory}");
            string saveDir = currentDir;
            currentDir = $"{currentDir}/{directory.GetName()}";
            var it = directory.GetEnumerator();
            while(it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                entry.Accept(this);
            }
            currentDir = saveDir;
        }
    }
}
