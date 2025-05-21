using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMVCWebApp.Models;

namespace MyMVCWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ITIDBContext itiDb = new ITIDBContext();
        var trainees = itiDb.Trainees.Select(t => new { t.Id, t.Name }).ToList();
        var courses = itiDb.Courses.Select(c => new { c.Id, c.Name }).ToList();
        ViewBag.Courses = courses;
        ViewBag.Trainees = trainees;
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
}
