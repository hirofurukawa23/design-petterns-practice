using System;

namespace Visitor_pattern
{
    public abstract class Entry : IElement
    {
        public abstract string GetName();
        public abstract int GetSize();
        public Entry Add(Entry entry)
        {
            throw new FileTreatmentException("");
        }

        public void PrintList()
        {
            PrintList("");
        }

        public abstract void PrintList(string prefix);

        public override string ToString()
        {
            return $"{ GetName() }({ GetSize() })";
        }

        public abstract void Accept(Visitor v);
    }

    public class FileTreatmentException : Exception
    {
        public FileTreatmentException(string msg): base(msg)
        {
        }
    }
}
