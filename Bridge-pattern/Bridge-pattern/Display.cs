namespace Bridge_pattern
{
    public class Display
    {
        private DisplayImpl impl;
        public Display(DisplayImpl impl)
        {
            this.impl = impl;
        }

        public void Open() { impl.RowOpen(); }

        public void Print() { impl.RowPrint(); }

        public void Close() { impl.RowClose(); }

        public void DisplayString()
        {
            Open();
            Print();
            Close();
        }
    }
}
