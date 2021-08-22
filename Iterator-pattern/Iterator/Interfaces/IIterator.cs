namespace Iterator
{
    /// <summary>
    /// Iterator（反復子）
    /// </summary>
    public interface IIterator
    {
        bool HasNext();

        object Next();
    }
}
