using System.Collections.Generic;

namespace AbstractFactory_pattern.Factory
{
    public abstract class Tray : Item
    {
        protected IList<Item> tray = new List<Item>();
        public Tray(string caption) : base(caption)
        {
        }
        public void Add(Item item)
        {
            this.tray.Add(item);
        }
    }
}
