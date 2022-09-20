using Microsoft.AspNetCore.Mvc;
using MVCLearnCore.Models;

namespace MVCLearnCore.Controllers
{

    //Inherit มาจาก Controller
    public class HtmlHelperController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            int result = Syntax("5000","Jirawat",500); //เรียกใช้

            #region ตัวแปลพื้นฐาน

            string x = "Jirawat";
            int num = 100;
            double d = 0.5;
            long l = 100000;
            bool b = true;
            char c = 'c';
            object obj = "object test";
            #endregion


            #region ตัวแปรแบบวัตถุ Array List Class

            string[] arr1 = new string[5]; //length = 5
            arr1[0] = "Mr.Jirawat";
            arr1[1] = "Chayayan";

            // ถ้าไม่ได้ใส่ห้องที่เหลือ จะเท่ากับ null

            string[] arr2 = new string[3] { "aaaa","bbbb","cccc" };

            string[] arr3 = new string[] { "aaaa", "bbbb", "cccc" };

            ////dynamic Array ไม่ถูก
            //string[] arr4 = new string[] { };
            //arr4[0] = "AAA";
            //arr4[1] = "BBB";
            //arr4[2] = "CCC";

            string[] arr5 = null;
            arr5 = new string[10];


            List<string> liststr = new List<string>();
            List<string> liststr2 = null;
            liststr2 = new List<string>();

            liststr2.Add("ssss");
            liststr2.Add("aaaa");
            liststr2.Add("bbbb");

            //liststr2 count = 3

            List<string> liststr3 = new List<string>
            {
                "AAA","BBB","CCC","DDD"
            };

            List<string[]> liststr4 = new List<string[]>
            {
                new string[] {"AAA","BBB","CCC","DDD" },
                new string[] {"EEE","FFF","GGG","HHH" },
                arr2,
                arr3

            };


            List<int[]> liststr5 = new List<int[]>
            {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9},
            };

            Employee emp1 = new Employee();
            emp1.Code = "EMP001";
            emp1.Name = "Jirawat";
            emp1.Mobile = "0877591034";

            string _moblie555 = emp1.Mobile;
            var data = emp1.Syntax("dsds", "dadad", 5000);

            Employee emp2 = new Employee();
            emp2.Code = "EMP002";
            emp2.Name = "Jeeranan";
            emp2.Mobile = "0993930216";

            string _moblie556 = emp2.Mobile;
            var data2 = emp2.Syntax("dsdsgfgj", "djfgjadad", 50000);


            List<Employee> listEmp = new List<Employee>();
            listEmp.Add(emp1);
            listEmp.Add(emp2);
            listEmp.Add(new Employee { Code = "EMP003", Name = "Apiwat", Mobile = "0882421985" });

            var a = from emp in listEmp where emp.Code == "EMP002"
                    select emp;
            #endregion

            #region DataDictionary

            var dict = new Dictionary<int, string>();
            dict.Add(1, "AAA");
            dict.Add(2, "BBB");

            if(dict.ContainsKey(1))
            {
                string vaL3 = dict[1];
            }
            else
            {

            }

            var dict2 = new Dictionary<int, string>
            {
                {1,"AAAA"},
                {2,"BBBB"},
                {3,"CCCC"},
                {4,"DDDD"}
            };


            var dict3 = new Dictionary<int, Employee>()
            {
                {
                    1,new Employee
                    { 
                        Code="EMP001",
                        Name="Jirawat",
                        Mobile="0877591034"
                    } 
                },
                {
                    2,new Employee
                    {
                        Code="EMP002",
                        Name="Jeeranan",
                        Mobile="0882421985"
                    }
                }
            };

            #endregion



            return View();
        }

        [HttpPost]
        public IActionResult Index(MemBerData data)
        {
            return View();
        }

        //ประกาศ Function ภายใต้ Class เท่านั้น
        public int Syntax(string? x,string y, int num)
        {
            return num;
        }
    }
}
