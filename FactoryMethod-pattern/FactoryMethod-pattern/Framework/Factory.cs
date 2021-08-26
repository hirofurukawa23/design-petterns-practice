namespace FactoryMethod_pattern
{
    public abstract class Factory
    {
        protected Product Create(string owner)
        {
            Product p = CreateProduct(owner);
            RegisterProduct(p);
            return p;
        }

        // ==================================================================
        // protected はそのクラス内部と、派生クラスのインスタンスからアクセスできる
        // ※ protected internal と private protected に限られる
        // ==================================================================

        /// <summary>
        /// 製品を生成します。
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        protected internal abstract Product CreateProduct(string owner);

        /// <summary>
        /// 製品を登録します。
        /// </summary>
        /// <param name="product"></param>
        protected internal abstract void RegisterProduct(Product product);
    }
}
