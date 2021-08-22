using System;

namespace Adapter_pattern_inherite
{
    public class Banner
    {
        private string _str;

        public Banner(string str)
        {
            _str = str;
        }

        public void ShowWithParen()
        {
            Console.WriteLine($"({ _str })");
        }

        public void ShowWithAster()
        {
            Console.WriteLine($"*{ _str }*");
        }
    }
}
