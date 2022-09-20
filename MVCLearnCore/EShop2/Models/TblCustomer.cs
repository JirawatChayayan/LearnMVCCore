using System.ComponentModel.DataAnnotations;

namespace EShop2.Models
{
    public class TBLCUSTOMER
    {
        private DateTime _dt = DateTime.Now;




        [Key]
        [Display(Name = "Code :")]
        public string CODE { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [Display(Name = "Name :")]
        public string NAME { get; set; }

        [Required(ErrorMessage = "Please enter lastname")]
        [Display(Name = "LastName :")]
        public string LASTNAME { get; set; }

        [Required(ErrorMessage = "Please enter mobile")]
        [Display(Name = "Mobile :")]
        public string MOBILE { get; set; }

        [Required(ErrorMessage = "Please select job")]
        [Display(Name = "Job :")]
        public string JOB { get; set; }

        [Required(ErrorMessage = "Please select sex")]
        [Display(Name = "Sex :")]
        public string SEX { get; set; }

        public DateTime CREATE_DATE
        {
            get { return _dt; }
            set { _dt = value; }

        }


        public static string GenerateCode()
        {
            string strDT = DateTime.Now.Ticks.ToString();


            // "1518416541848541848" //19
            return "CD" + strDT.Substring(strDT.Length - 5, 5); //CD41848
        }

    }
}
