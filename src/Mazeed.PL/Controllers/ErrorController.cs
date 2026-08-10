using Microsoft.AspNetCore.Mvc;

namespace Mazeed.PL.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult Error(int statusCode)
        {
            return statusCode switch
            {
                400 => View("400"),
                401 => View("401"),
                403 => View("403"),
                404 => View("404"),
                405 => View("405"),
                408 => View("408"),
                409 => View("409"),
                422 => View("422"),
                429 => View("429"),
                500 => View("500"),
                502 => View("502"),
                503 => View("503"),
                504 => View("504"),

                _ => View("Error")
            };
        }
    }
}
