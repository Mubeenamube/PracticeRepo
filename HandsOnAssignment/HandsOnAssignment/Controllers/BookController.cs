using HandsOnAssignment.Model;
using HandsOnAssignment.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookRepository rep;

        public BookController()
        {
            rep = new BookRepository();
        }
        [HttpGet, Route("GetAllBook")]
        public IActionResult GetAllBook()
        {
            try
            {
                List<Book> books = rep.GetAllBook();
                return StatusCode(200, books);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }


        [HttpPost, Route("AddBook")]
        public IActionResult AddBook(Book book)
        {
            try
            {
                rep.AddBook(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpDelete, Route("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                rep.DeleteBook(id);
                return StatusCode(200, "book deleted");
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpPut, Route("EditBook")]
        public IActionResult EditBook(Book book)
        {
            try
            {
                rep.EditBook(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpGet,Route("GetBookByAuthor/{author}")]
        public IActionResult GetBookByAuthor(string author)
        {
            try
            {
                rep.GetBookByAuthor(author);
                return StatusCode(200,author);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }


        [HttpGet, Route("GetBookByLang/{lang}")]
        public IActionResult GetBookByLang(string lang)
        {
            try
            {
                return StatusCode(200, rep.GetBookByLang(lang));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpGet, Route("GetBookByYear/{year}")]
        public IActionResult GetBookByYear(int year)
        {
            try
            {
                return StatusCode(200, rep.GetBookByYear(year));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
    }
}
