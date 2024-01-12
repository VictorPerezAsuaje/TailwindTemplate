using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebClient.Utilities;
using TailwindTemplate.Application.Security.DTOs;

namespace WebClient.Controllers;

public class HomeController : ExtendedController
{
    public IActionResult Index()
    {
        Notify("Hello there!");

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorDTO { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
