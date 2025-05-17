using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TryMVC.Models;

namespace TryMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult LogUser(int id, string username)
    {
        if (id == 1)
            return Content("Hello Admin");
        else
        {
            ViewData["Username"] = username;
            return View("View1");
        }
    }
}
