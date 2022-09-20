using System.ComponentModel.DataAnnotations;

namespace MVCLearnCore.Models
{
    public class MemBerData
    {
        #region Properties
        [Display(Name = "ชื่อ")]
        public string? NAME { get; set; }
        [Display(Name = "นามสกุล")]
        public string? LASTNAME { get; set; }

        [Required(ErrorMessage = "Mobile is need")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile is not Valid")]
        public string? MOBILE { get; set; }

        [Display(Name = "อาชีพ")]
        public string? JOB { get; set; }

        [Display(Name = "งานอดิเรก")]
        public string? HOBBY { get; set; }

        [Display(Name = "เพศ")]
        public string? SEX { get; set; }

        #endregion

    }
}
