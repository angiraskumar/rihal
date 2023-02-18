using System;
using System.Collections.Generic;
using System.Text;

namespace CurdOperation.Models
{
    public class StudentModel
    {
        
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int? ClassId { get; set; }
        public int? CountryId { get; set; }
    }
}
