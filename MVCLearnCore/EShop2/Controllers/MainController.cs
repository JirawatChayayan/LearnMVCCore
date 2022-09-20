using EShop2.Models;
using Microsoft.AspNetCore.Mvc;

namespace EShop2.Controllers
{
    public class MainController : Controller
    {


        private readonly TblCostomerContext _dbContext;

        public MainController(TblCostomerContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult Index()
        {
            //get data to job


            List<TBLJOB> mmm = new List<TBLJOB>();

            TBLJOB _j = new TBLJOB();

            _j.ID = "111111";
            _j.NAME = "Teacher";

            mmm.Add(_j);

            TBLJOB _j2 = new TBLJOB();

            _j2.ID = "222222";
            _j2.NAME = "Docter";

            mmm.Add(_j2);



            List<TBLJOB> listJob = new List<TBLJOB>() { new TBLJOB { ID = "0001", NAME = "Engineer" }, new TBLJOB { ID = "0002", NAME = "Programmer" } };


            listJob.Insert(0, new TBLJOB { ID = null, NAME = "------Please Select Job------" });

            ViewBag.ListJob = listJob;


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Index(TBLCUSTOMER _customer)
        {


            //get data to job

            List<TBLJOB> listJob = new List<TBLJOB>()

            { new TBLJOB { ID = "0001", NAME = "Engineer" } , new TBLJOB { ID="0002" , NAME = "Programmer" } };


            listJob.Insert(0, new TBLJOB
            {
                ID = null
                ,
                NAME = "------Please Select Job------"
            });

            ViewBag.ListJob = listJob;



            if (ModelState.IsValid)
            {
                TBLCUSTOMER _result = new TBLCUSTOMER();

                _result = _customer;
                _result.CODE = TBLCUSTOMER.GenerateCode();

                _dbContext.Add(_result);

                await _dbContext.SaveChangesAsync();


            }

            return View();

        }
    }
}
