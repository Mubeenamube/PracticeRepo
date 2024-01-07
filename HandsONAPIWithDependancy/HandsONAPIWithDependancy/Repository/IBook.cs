using HandsONAPIWithDependancy.Model;

namespace HandsONAPIWithDependancy.Repository
{
    public interface IBook
    {
        void AddBook(Book book);

        List<Book> GetAllBooks();

        List<Book> GetBooksByAuthor(string Autor);

        List<Book> GetBooksByLang(string lang);

        List<Book> GetBooksByYear(int year);

        void EditBook(Book book);

        void DeleteBook(int bookId);
        Book GetBookById(int bookId);
        Book GetBookByName(string name);
    }
}
