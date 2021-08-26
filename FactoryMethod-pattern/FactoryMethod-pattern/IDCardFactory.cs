using System.Collections.Generic;

namespace FactoryMethod_pattern
{
    public class IDCardFactory : Factory
    {
        private List<string> _owners = new List<string>();

        /// <summary>
        /// 製品を生成します。
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        protected internal override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        /// <summary>
        /// 製品を登録します。
        /// </summary>
        /// <param name="product"></param>
        protected internal override void RegisterProduct(Product product)
        {
            _owners.Add((product as IDCard).GetOwner());
        }

        public List<string> GetOwners()
        {
            return _owners;
        }
    }
}
