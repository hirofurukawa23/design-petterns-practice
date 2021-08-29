using System;

namespace Prototype_pattern
{
    public interface IProduct : ICloneable
    {
        void Use(string s);

        IProduct CreateClone();
    }
}
