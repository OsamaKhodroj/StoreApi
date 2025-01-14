using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyX.Store.Domains.Entites
{

    [Table("Orders")]
    public class Order : BaseClass
    {
        [Required] 
        public int  UserId { get; set; }

        [Required]
        public int ProductId { get; set; } 
    }
}
