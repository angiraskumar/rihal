using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CurdOperation.Repo.Enitity
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [Required]
        [MaxLength(128)]
        public string CountryName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
