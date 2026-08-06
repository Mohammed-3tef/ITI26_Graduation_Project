using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mazeed.DAL.Entities;

namespace Mazeed.PL.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
