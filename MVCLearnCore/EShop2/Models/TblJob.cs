using System.ComponentModel.DataAnnotations;

namespace EShop2.Models
{
    public class TBLJOB
    {
        [Key]
        public string ID { get; set; }
        public string NAME { get; set; }

    }
}
