using System;
using System.Text;

namespace Prototype_pattern
{
    public class MessageBox : IProduct
    {
        private char _decoChar;

        public MessageBox(char decochar)
        {
            _decoChar = decochar;
        }

        public void Use(string s)
        {
            var length = Encoding.GetEncoding("shift_jis").GetBytes(s).Length;
            for (var i = 0; i < length + 4; i++)
            {
                Console.Write(_decoChar);
            }
            Console.WriteLine(" ");
            Console.WriteLine($"{ _decoChar } { s } { _decoChar }");
            for (var i = 0; i < length + 4; i++)
            {
                Console.Write(_decoChar);
            }
            Console.WriteLine(" ");
        }

        public object Clone()
        {
            //Shallow Copyのみ行うようにする
            return this.MemberwiseClone();
        }

        public IProduct CreateClone()
        {
            IProduct p = null;
            try
            {
                p = (IProduct)Clone();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return p;
        }
    }
}
