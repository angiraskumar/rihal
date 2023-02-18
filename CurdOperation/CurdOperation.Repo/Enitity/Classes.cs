using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CurdOperation.Repo.Enitity
{
    public class Classes
    {
        [Key]
        public int ClassId { get; set; }
        [Required]
        [MaxLength(128)]
        public string ClassName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
