using Librarian;
using System.Collections.Concurrent;

namespace Libraian
{
    class Program
    {

        private static void Main()
        {
            ConcurrentDictionary<string, int> books = new ConcurrentDictionary<string, int>();
            Books bookMethod = new Books(books);

            try
            {
                Thread calculatePercentThread = new (bookMethod.СalculationPercent);
                calculatePercentThread.Start();
                while (true)
                {
                    Console.WriteLine("1 - добавить книгу; \n2 - вывести список непрочитанного; \n3 - выйти");
                    var number = Console.ReadLine();
                    if (int.TryParse(number, out int numberP)) 
                    {
                        int numberParse = int.Parse(number);
                        switch (numberParse)
                        {
                            case 1:
                                Console.WriteLine("Введите название книги:");
                                var nameBook = Console.ReadLine();
                                bookMethod.AddBook(nameBook);
                                break;
                            case 2:
                                bookMethod.ShowBooks();
                                break;
                            case 3:
                                Environment.Exit(0);
                                break;
                        }
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Введите цифру от 1 до 3. Ошибка - {e}");
            }

        }

    }
}