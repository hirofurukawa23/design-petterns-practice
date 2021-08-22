using System.Collections.Generic;

namespace Iterator
{
    /// <summary>
    /// ConcreteAggregate
    /// </summary>
    public class BookShelf : IAggregate
    {
        private List<Book> _books;
        private int _last = 0;
        
        public BookShelf()
        {
            _books = new List<Book>();
        }

        public void AppendBook(Book book)
        {
            _books.Add(book);
            _last++;
        }

        public int GetLength()
            => _last;

        public Book GetBookAt(int index)
            => _books[index];

        /// <summary>
        /// 数え上げ処理を実行するオブジェクトを返却する
        /// </summary>
        /// <returns></returns>
        public IIterator Iterator()
            => new BookShelfIterator(this);
    }
}
