using System;

namespace Decorator_pattern
{
    public abstract class Display
    {
        public abstract int GetColumns();
        public abstract int GetRows();
        public abstract string GetRowText(int row);
        public void Show()
        {
            for(var i = 0; i < GetRows(); i++)
            {
                Console.WriteLine(GetRowText(i));
            }
        }
    }
}
