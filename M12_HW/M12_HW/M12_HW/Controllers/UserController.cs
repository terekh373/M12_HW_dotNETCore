using Microsoft.AspNetCore.Mvc;

namespace M12_HW.Controllers
{
    public class UserController : Controller
    {
        // http://localhost:port/user/register
        [HttpGet]
        public IActionResult Register() => View();

        // http://localhost:port/user/login
        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {
            // Поки що як заглушка
            if (Email == "test@test.com" && Password == "12345")
            {
                TempData["Message"] = "Login success!";
                return RedirectToAction("Index", "Home");
            }

            TempData["Message"] = "Invalid credentials!";
            return View();
        }
    }
}
