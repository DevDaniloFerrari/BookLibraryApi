using BookLibraryApi.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers
{
    [ApiController]
    [Route("books")]
    public class BookController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetBooks([FromServices] IGetBooksService service)
        {
            //Only to be able to show spinner on frontend
            await Task.Delay(1000);

            var result = service.GetBooks();
            return Ok(result);
        }

        [HttpGet("{property}/{value}")]
        public async Task<IActionResult> GetBooks([FromServices] IGetBooksService service, [FromRoute] string property, [FromRoute] string value)
        {
            //Only to be able to show spinner on frontend
            await Task.Delay(1000);

            var result = service.GetBooks(property, value);
            return Ok(result);
        }
    }
}
