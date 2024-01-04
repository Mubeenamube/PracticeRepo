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
        [HttpPost,Route("AddBook")]
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

        [HttpDelete, Route("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                rep.DeleteBook(id);
                return StatusCode(200, "Teacher Deleted");
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

        [HttpGet, Route("GetBookByAuthor/{author}")]
        public IActionResult GetBookByAuthor(string author)
        {
            try
            {
                return StatusCode(200, rep.GetBookByAuthor(author));
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
        [HttpGet,Route("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                Book book = rep.GetBookById(id);
                if (book != null)
                    return StatusCode(200, book);
                else
                    return StatusCode(404, new JsonResult("Invalid book Id")); 
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet,Route("GetByName/{name}")]
        public IActionResult GetByName(string name)
        {
            try
            {
                Book book = rep.GetBookByName(name);
                if (book != null)
                    return StatusCode(200, book);
                else
                    return StatusCode(404, new JsonResult("Invalid book name"));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
    }
}
