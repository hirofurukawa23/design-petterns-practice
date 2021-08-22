namespace Iterator
{
    /// <summary>
    /// ConcreteIterator
    /// </summary>
    public class BookShelfIterator : IIterator
    {
        private BookShelf _bookShelf;
        private int _index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            _bookShelf = bookShelf;
            _index = 0;
        }

        public bool HasNext()
            => _index < _bookShelf.GetLength() ? true : false;

        public object Next()
        {
            Book book = _bookShelf.GetBookAt(_index);
            _index++;
            return book;
        }
    }
}
