using System;
using System.Text;

namespace Bridge_pattern
{
    public class StringDisplayImpl : DisplayImpl
    {
        private string _string;
        private int _width;

        public StringDisplayImpl(string _string)
        {
            this._string = _string;
            this._width = Encoding.GetEncoding("shift_jis").GetBytes(this._string).Length;
        }

        internal override void RowClose()
        {
            PrintLine();
        }

        internal override void RowOpen()
        {
            PrintLine();
        }

        internal override void RowPrint()
        {
            Console.WriteLine($"|{ _string }|");
        }

        private void PrintLine()
        {
            Console.Write("+");
            for(var i = 0; i < _width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
