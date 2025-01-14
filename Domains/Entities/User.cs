using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyX.Store.Domains.Entites
{

    [Table("Users")]
    public class User : BaseClass
    {

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string EmailAddress { get; set; }

        [Required]
        [MaxLength(100)]
        public string  Password { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        public UserStatus UserStatus { get; set; } = UserStatus.Active;
    }
}
