using Microsoft.AspNetCore.Mvc;
using MVCLearnCore.Models;

namespace MVCLearnCore.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(MemBerData dataItem)
        {
            return View();
        }
    }
}
