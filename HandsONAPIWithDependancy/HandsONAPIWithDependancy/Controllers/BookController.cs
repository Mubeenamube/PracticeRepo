using HandsONAPIWithDependancy.Model;
using HandsONAPIWithDependancy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsONAPIWithDependancy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBook bookrepo;
        public BookController(IBook bookrepo)
        {
            this.bookrepo = bookrepo;
        }
        //GetAll
        [HttpGet,Route("GetAllBook")]
        public IActionResult GetAll()
        {

            try
            {
                List<Book> books = bookrepo.GetAllBooks();
                return StatusCode(200, books);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        //Add
        [HttpPost,Route("AddBook")]
        public IActionResult Get(Book book)
        {
            try
            {
                bookrepo.AddBook(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }

        }

        //delete
        [HttpDelete,Route("BookDelete/{id}")]
        public IActionResult DeleteBook(int  id)
        {
            try
            {
                bookrepo.DeleteBook(id);
                return StatusCode(200, "deleted");

            }
            catch (Exception)
            {

                throw;
            }

        }
        //update
        [HttpPut,Route("EditBook")]
        public IActionResult EditBook(Book book)
        {
            try
            {
                bookrepo.EditBook(book);
                return StatusCode(200, "updated");
            }
            catch (Exception)
            {

                throw;
            }
        }

        //getbookbyid
        [HttpGet,Route("GetBookById/{id}")]
        public IActionResult GetBookById(int id) 
        {
            try
            {

                Book books = bookrepo.GetBookById(id);
                if (books != null)
                    return StatusCode(200, books);
                else
                    return StatusCode(404, new JsonResult("Invalid book Id")); //JsonResult send data in json format
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        //get book by author
        [HttpGet, Route("GetBookByAuthor/{Author}")]
        public IActionResult GetTeacherBySubject(string Author)
        {
            try
            {
                return StatusCode(200, bookrepo.GetBooksByAuthor(Author));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
    }
}
