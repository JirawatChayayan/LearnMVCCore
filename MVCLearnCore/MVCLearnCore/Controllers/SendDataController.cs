using Microsoft.AspNetCore.Mvc;
using MVCLearnCore.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MVCLearnCore.Controllers
{
    public class SendDataController : Controller
    {
        public IActionResult Index()
        {
            #region tempData

            TempData["ttt"] = "Jirawat";


            Employee emp = new Employee
            {
                Name = "Jirawat",
                Code = "EMP001"
            };

            TempData["ddd"] = JsonSerializer.Serialize(emp);

            #endregion

            // 
            #region Model ViewBag ViewData


            ViewBag.y = "Maner";
            ViewBag.Z = 12345;
            ViewBag.X = emp;


            ViewData["lst"] = new List<Employee>
            {
                emp,
                new Employee
                {
                    Name = "Jirawat",
                    Code = "EMP001",
                    Mobile = "0877591034"
                },
                new Employee
                {
                    Name = "Jeeranan",
                    Code = "EMP002",
                    Mobile = "0993930216"
                }

             };

            return View(emp);

            #endregion



            //Method , Controller
            //return RedirectToAction("Main", "SendData");
            //return RedirectToAction("Index", "WaitResult");
        }

        public IActionResult Main()
        {
            if(TempData["ttt"] != null)
            {
                string str = TempData["ttt"].ToString();
            }

            if(TempData["ddd"] != null)
            {
                string str2 = TempData["ddd"].ToString();

                Employee? emp = JsonSerializer.Deserialize<Employee>(str2);
            }
            return View();
        }
    }
}
