using Adapter_pattern_inherite.Interfaces;

namespace Adapter_pattern_inherite
{
    public class PrintBanner : Banner, IPrint
    {
        public PrintBanner(string str):base(str)
        { }

        public void PrintStrong()
        {
            ShowWithAster();
        }

        public void PrintWeak()
        {
            ShowWithParen();
        }
    }
}
