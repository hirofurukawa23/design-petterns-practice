using System;

namespace Composite_pattern
{
    public abstract class Entry
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
    }

    public class FileTreatmentException : Exception
    {
        public FileTreatmentException(string msg): base(msg)
        {
        }
    }
}
