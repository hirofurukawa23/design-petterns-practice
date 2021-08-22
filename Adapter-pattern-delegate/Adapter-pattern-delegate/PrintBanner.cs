namespace Adapter_pattern_delegate
{
    public class PrintBanner : Print
    {
        private Banner _banner;

        public PrintBanner(string str)
        {
            this._banner = new Banner(str);
        }

        public override void PrintWeak()
        {
            _banner.ShowWithParen();
        }

        public override void PrintStrong()
        {
            _banner.ShowWithAster();
        }
    }
}
