using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CurdOperation.Repo.Enitity
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [MaxLength(128)]
        public string StudentName { get; set; }
        public int ClassId { get; set; }
        public int CountryId { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
