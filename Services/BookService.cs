using CetStudent.Models;

namespace CetStudent.Services
{
    public class BookService
    {
        List<Book> books = new List<Book>();

        public BookService()
        {
            loadBooks();
        }

        private void loadBooks()
        {
            Book book1 = new Book();
            book1.Name = "Tutunamayanlar";
            book1.Author = "Oğuz Atay";
            book1.Price = 140;

            Book book2 = new Book();
            book2.Name = "Tehlikeli Oyunlar";
            book2.Author = "Oğuz Atay";
            book2.Price = 200;

            Book book3 = new Book();
            book3.Name = "C#";
            book3.Author = "Hüseyin Şimşek";
            book3.Price = 100;

            books.Add(book1);
            books.Add(book2);

            books.Add(book3);
        }

        public Book GetRandomBook()
        { 
           Random rnd = new Random();
           return  books[rnd.Next(books.Count)];
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
    }
}
