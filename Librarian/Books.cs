using System.Collections.Concurrent;

namespace Librarian
{
    internal class Books
    {
        private ConcurrentDictionary<string, int> _books;
        public Books(ConcurrentDictionary<string, int> books)
        {
            _books = books;
        }
        public void AddBook(string? nameBook)
        {
            if (nameBook == null)
                return;
            if (_books.ContainsKey(nameBook))
            {
                Console.WriteLine("Такая книга существует! Добавьте другую");
            }
            else
            {
                _books.TryAdd(nameBook, 0);
            }
        }

        public void ShowBooks()
        {
            foreach (var book in _books)
            {
                Console.WriteLine($"Название книги - {book.Key}, книга прочитана на {book.Value}%.");
            }
        }

        public void СalculationPercent()
        {
            while (true)
            {
                foreach (var book in _books)
                {
                    _books.TryUpdate(book.Key, book.Value + 1, book.Value);

                    if (book.Value == 100)
                    {
                        _books.TryRemove(book.Key, out _);
                    }
                }
                Thread.Sleep(1000);
            }
        }
    }
}
