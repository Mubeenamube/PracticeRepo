using System.Net;
using HandsONAPIWithDependancy.Model;

namespace HandsONAPIWithDependancy.Repository
{
    public class BookRepository : IBook
    {
        public List<Book> books= new List<Book>();
        public void AddBook(Book book)
        {
            try
            {
                books.Add(book);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteBook(int bookId)
        {
            try
            {
                foreach(var item in books)
                {
                    if(item.BookId == bookId)
                    {
                        books.Remove(item);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditBook(Book book)
        {
            foreach(var item in books)
            {
                if(item.BookId==book.BookId)
                {
                    item.BookId = book.BookId;
                    item.BookName = book.BookName;
                    break;
                }
                
            }
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBookById(int bookId)
        {
            try
            {
                foreach (var item in books)
                {
                    if (item.BookId == bookId)
                        return item;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Book GetBookByName(string name)
        {
            try
            {
                foreach (var item in books)
                {
                    if (item.BookName == name)
                        return item;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBooksByAuthor(string Autor)
        {
            try
            {
                List<Book> bookbyauthor = new List<Book>();
                foreach (var item in books)
                {
                    if(item.BookAuthor == Autor)
                        bookbyauthor.Add(item);
                }
                return bookbyauthor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBooksByLang(string lang)
        {
            try
            {
                List<Book> bookbylang = new List<Book>();
                foreach (var item in books)
                {
                    if (item.BookLang == lang)
                        bookbylang.Add(item);
                }
                return bookbylang;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBooksByYear(int year)
        {
            try
            {
                List<Book> bookbyyear = new List<Book>();
                foreach (var item in books)
                {
                    if (item.BookReleaseYear == year)
                        bookbyyear.Add(item);
                }
                return bookbyyear;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
