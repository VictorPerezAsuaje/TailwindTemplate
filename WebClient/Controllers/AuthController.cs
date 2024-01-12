using Microsoft.AspNetCore.Mvc;
using WebClient.Utilities;

namespace WebClient.Controllers;

public class AuthController : ExtendedController
{
    [HttpGet("login")]
    public async Task<IActionResult> LoginAsync()
    {
        if (User.Identity.IsAuthenticated)
        {
            Notify(x =>
            {
                x.Title = "You are logged in!";
                x.Message = "No worries, no need to log in again 😉";
                x.Icon = NotificationIcon.info;
            });

            return RedirectToAction("Index", "Home");
        }

        return View();
    }
}
