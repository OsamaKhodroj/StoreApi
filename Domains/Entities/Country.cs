﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyX.Store.Domains.Entites
{

    [Table("Countries")]
    public class Country
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
