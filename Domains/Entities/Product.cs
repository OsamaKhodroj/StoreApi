using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyX.Store.Domains.Entites
{

    [Table("Products")]
    public class Product : BaseClass
    {

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required] 
        public double Price { get; set; }

         
        [MaxLength(1000)]
        public string? Description { get; set; }

    }
}
