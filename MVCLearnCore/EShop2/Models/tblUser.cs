
using System.ComponentModel.DataAnnotations; //attribute+
namespace EShop2.Models
{
    public class TBLUSER
    {
        [Key]
        [Required]
        [Display(Name = "UserName :")]
        public string USERNAME { get; set; }
        
        [Required]
        [Display(Name ="Password :")]
        public string PASSWORD { get; set; }

        [Required,Display(Name ="Role :")]
        public string ROLE { get; set; }

    }
}
