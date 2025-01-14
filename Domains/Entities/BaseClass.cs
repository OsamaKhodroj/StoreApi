using System.ComponentModel.DataAnnotations;

namespace CompanyX.Store.Domains.Entites
{
    public class BaseClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
} 