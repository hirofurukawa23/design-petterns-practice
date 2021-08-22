using System;
using System.Text;

namespace TemplateMethod_pattern
{
    public class StringDisplay : AbstractDisplay
    {
        private string _str;
        private int _width;
        public StringDisplay(string str)
        {
            _str = str;
            //バイナリにエンコードして幅を取得して保持しておく
            _width = Encoding.GetEncoding("shift_jis").GetBytes(str).Length;
        }

        public override void Open()
        {
            PrintLine();
        }

        public override void Print()
        {
            Console.WriteLine($"|{ _str }|");
        }
        public override void Close()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            var r = new StringBuilder();
            r.Append("+");
            for (var i = 0; i < _width; i++)
            {
                r.Append("-");
            }
            r.Append("+");
            Console.WriteLine(r.ToString());
        }
    }
}
