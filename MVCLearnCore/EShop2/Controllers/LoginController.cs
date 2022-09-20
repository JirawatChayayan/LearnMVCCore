using EShop2.Models;
using Microsoft.AspNetCore.Mvc;

using EShop2.DataAccess;
namespace EShop2.Controllers
{
    public class LoginController : Controller
    {
        private TblUserContext _dbcontext;
        public LoginController(TblUserContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(TBLUSER user)
        {
            if(user.USERNAME != null && user.PASSWORD != null)
            {
                string usr = user.USERNAME.ToString();
                string pwd = user.PASSWORD.ToString();

                TBLUSER? res = _dbcontext.Tbluser.ToList().Where(u => 
                                                                 u.USERNAME == usr && 
                                                                 u.PASSWORD == pwd)
                                                                .FirstOrDefault();
                if(res != null)
                {
                    ViewBag.name = res.USERNAME;
                    return RedirectToAction("Index", "Main");
                }
            }
            return View();
        }
    }
}
