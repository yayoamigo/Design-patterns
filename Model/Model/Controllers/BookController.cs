using Microsoft.AspNetCore.Mvc;
using Model.Models;

namespace Model.Controllers
{
    public class BookController : Controller
    {

        [Route("books")]
        public IActionResult Index([Bind(nameof(Book.bookid), nameof(Book.email), nameof(Book.Date))] Book book)
        {
            if (!ModelState.IsValid)
            {
                string error = string.Join("\n", 
                    ModelState.Values.SelectMany(errors => errors.Errors).Select(err => err.ErrorMessage));

                return BadRequest(error);
            }

            return Content(book.ToString());
            

           


            
        }
    }
}
