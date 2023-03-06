using BookLibraryApi.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers
{
    [ApiController]
    [Route("books")]
    public class BookController : Controller
    {

        [HttpGet]
        public IActionResult GetBooks([FromServices] IGetBooksService service)
        {
            var result = service.GetBooks();
            return Ok(result);
        }
    }
}
