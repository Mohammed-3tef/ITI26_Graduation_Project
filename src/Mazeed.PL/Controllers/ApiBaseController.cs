using Mazeed.BLL.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Mazeed.PL.Controllers
{
    [ApiController]
    public abstract class ApiBaseController : ControllerBase
    {
        protected long CurrentUserId =>
            long.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

        protected string CurrentUserName =>
            User.FindFirstValue(ClaimTypes.Name) ?? User.Identity?.Name ?? "System";

        protected IActionResult HandleResponse<T>(ServiceResponse<T> response)
        {
            return response.Succeeded ? Ok(response) : BadRequest(response);
        }
    }
}