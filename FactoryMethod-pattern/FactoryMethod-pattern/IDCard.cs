using System;

namespace FactoryMethod_pattern
{
    public class IDCard : Product
    {
        private string _owner;
        public IDCard(string owner)
        {
            Console.WriteLine($"{ owner }のカードを作成します。");
            this._owner = owner;
        }
        public override void Use()
        {
            Console.WriteLine($"{ this._owner }のカードを使用します。");
        }

        public string GetOwner()
        {
            return this._owner;
        }
    }
}
