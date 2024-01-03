using HandsOnAssignment.Model;

namespace HandsOnAssignment.Repository
{
    public interface IBook
    {
        void AddBook(Book book);
        List<Book> GetAllBook();
        List<Book> GetBookByAuthor(string author);
        List<Book> GetBookByLang(string lang);
        List<Book> GetBookByYear(int year);
        void EditBook(Book book);
        void DeleteBook(int id);


    }
}
