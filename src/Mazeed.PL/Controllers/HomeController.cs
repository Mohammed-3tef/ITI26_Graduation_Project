using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mazeed.PL.Controllers;

public class HomeController : Controller
{
    private readonly IEmailService _emailService;

    public HomeController(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy() => View();

    [HttpGet]
    public IActionResult Contact() => View();

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Contact(ContactVM model)
    {
        if (!ModelState.IsValid) return View(model);

        try
        {
            await _emailService.ProcessContactFormAsync(model);
            TempData["SuccessMessage"] = "Your message has been sent successfully. We will get back to you soon.";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, "An error occurred while sending your message. Please try again later.");
            return View(model);
        }
    }
}
