using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMVCWebApp.Models;

namespace MyMVCWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ITIDBContext _context; // Add your DbContext here

    public HomeController(ILogger<HomeController> logger, ITIDBContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [HttpPost]
    public IActionResult Login(string username)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            ViewBag.Message = "Please enter a valid username.";
            return View("Index");
        }

        // Check if username exists in Instructor table
        var instructor = _context.Instructors
            .FirstOrDefault(i => i.Name == username); // Adjust property name as needed

        if (instructor != null)
        {
            // User is an instructor
            HttpContext.Session.SetString("Username", username);
            HttpContext.Session.SetString("UserType", "Instructor");
            HttpContext.Session.SetString("SessionStartTime", DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString());

            return RedirectToAction("Index");
        }

        // Check if username exists in Trainee table
        var trainee = _context.Trainees
            .FirstOrDefault(t => t.Name == username); // Adjust property name as needed

        if (trainee != null)
        {
            // User is a trainee
            HttpContext.Session.SetString("Username", username);
            HttpContext.Session.SetString("UserType", "Trainee");
            HttpContext.Session.SetString("SessionStartTime", DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString());

            return RedirectToAction("Index");
        }

        // Username not found in either table
        ViewBag.Message = $"Username '{username}' not found. Please check your username and try again.";
        return View("Index");
    }

    public IActionResult Logout()
    {
        var username = HttpContext.Session.GetString("Username");

        // Clear the session
        HttpContext.Session.Clear();

        ViewBag.Message = "You have been successfully logged out.";
        return View("Index");
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

    private bool IsSessionValid()
    {
        var sessionStartTimeString = HttpContext.Session.GetString("SessionStartTime");
        if (string.IsNullOrEmpty(sessionStartTimeString))
            return false;

        if (long.TryParse(sessionStartTimeString, out long sessionStartTime))
        {
            var elapsedTime = DateTimeOffset.Now.ToUnixTimeMilliseconds() - sessionStartTime;
            var sessionDurationMs = 30 * 60 * 1000; // 30 minutes in milliseconds

            return elapsedTime < sessionDurationMs;
        }

        return false;
    }
}
