using System.Collections.Generic;

namespace Prototype_pattern
{
    public class Manager
    {
        private Dictionary<string, IProduct> _showcase = new Dictionary<string, IProduct>();

        public void Register(string name, IProduct product)
        {
            _showcase.Add(name, product);
        }

        public IProduct Create(string protoname)
        {
            if (!_showcase.ContainsKey(protoname)) { return null; }
            IProduct p = (IProduct)_showcase[protoname];
            return (IProduct)p.CreateClone();
        }
    }
}
