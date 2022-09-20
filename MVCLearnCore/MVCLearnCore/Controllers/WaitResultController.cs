using Microsoft.AspNetCore.Mvc;
using MVCLearnCore.Models;
using System.Text.Json;

namespace MVCLearnCore.Controllers
{
    public class WaitResultController : Controller
    {
        public IActionResult Index()
        {
            if (TempData["ttt"] != null)
            {
                string str = TempData["ttt"].ToString();
            }
            if(TempData["ddd"] != null)
            {
                string str2 = TempData["ddd"].ToString();

                Employee emp = JsonSerializer.Deserialize<Employee>(str2);
            }
            return View();
        }
    }
}
