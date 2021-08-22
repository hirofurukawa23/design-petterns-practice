using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf();
            bookShelf.AppendBook(new Book("A"));
            bookShelf.AppendBook(new Book("B"));
            bookShelf.AppendBook(new Book("C"));
            bookShelf.AppendBook(new Book("D"));

            IIterator it = bookShelf.Iterator();
            
            while (it.HasNext())
            {
                Book book = (Book)it.Next();
                Console.WriteLine(book.GetName());
            }
            Console.ReadLine();
        }
    }
}
