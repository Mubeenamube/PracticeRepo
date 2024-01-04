using HandsOnAssignment.Model;

namespace HandsOnAssignment.Repository
{
    public class BookRepository : IBook
    {
        public static List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DeleteBook(int id)
        {
            try
            {
                foreach (var item in books)
                {
                    if (item.Id == id)
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
            try
            {
                foreach (var item in books)
                {
                    if (item.Id == book.Id)
                    {
                        item.Name = book.Name;
                        item.Price = book.Price;
                        item.Author = book.Author;
                        item.Releaseyear = book.Releaseyear;
                        item.Publisher = book.Publisher;
                        break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetAllBook()
        {
            try
            {
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBookByAuthor(string author)
        {
            try
            {
                List<Book> bookbyauthor = new List<Book>();
                foreach (var item in books)
                {
                    if (item.Author == author)
                    {
                        bookbyauthor.Add(item);
                    }
                }
                return bookbyauthor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Book GetBookById(int id)
        {
            try
            {
                foreach (var item in books)
                {
                    if (item.Id == id)
                        return item;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBookByLang(string lang)
        {
            try
            {
                List<Book> bookbylang = new List<Book>();
                foreach (var item in books)
                {
                    if (item.Lang == lang)
                    {
                        bookbylang.Add(item);
                    }
                }
                return bookbylang;
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
                    if(item.Name == name)
                    {
                        return item;
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBookByYear(int year)
        {
            try
            {
                List<Book> bookbyyear = new List<Book>();
                foreach (var item in books)
                {
                    if (item.Releaseyear == year)
                    {
                        bookbyyear.Add(item);
                    }
                }
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
