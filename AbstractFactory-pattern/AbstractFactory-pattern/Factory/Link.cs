namespace AbstractFactory_pattern.Factory
{
    public abstract class Link : Item
    {
        protected string url;
        public Link(string caption, string url) : base(caption)
        {
            this.url = url;
        }
    }
}
