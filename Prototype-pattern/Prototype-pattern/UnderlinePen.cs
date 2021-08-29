using System;
using System.Text;

namespace Prototype_pattern
{
    public class UnderlinePen : IProduct
    {
        private char _ulChar;

        public UnderlinePen(char ulchar)
        {
            _ulChar = ulchar;
        }

        public void Use(string s)
        {
            var length = Encoding.GetEncoding("shift_jis").GetBytes(s).Length;
            Console.WriteLine($"\" { s } \"");
            for (var i = 0; i < length + 4; i++)
            {
                Console.Write(_ulChar);
            }
            Console.WriteLine(" ");
        }

        public object Clone()
        {
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
