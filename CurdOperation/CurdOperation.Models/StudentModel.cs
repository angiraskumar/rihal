using System;
using System.Collections.Generic;
using System.Text;

namespace CurdOperation.Models
{
    public class StudentModel: CommonModel
    {
        
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string ClassId { get; set; }
        public string CountryId { get; set; }

        public string CountryName { get; set; }
        public string ClassName { get; set; }

    }
}
