using CurdOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurdOperation.Services
{
    public class StudentService : IStudentService
    {
        public Task AddStudent(StudentModel student)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StudentModel>> GetStudent()
        {
            IList<StudentModel> model = new List<StudentModel>();
            model.Add(new StudentModel
            {

            });

            throw new NotImplementedException();
        }

        public Task<StudentModel> GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStudent(StudentModel student)
        {
            throw new NotImplementedException();
        }
    }
}
