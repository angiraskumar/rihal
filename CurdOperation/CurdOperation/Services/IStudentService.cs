using CurdOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurdOperation.Services
{
    public interface IStudentService
    {
        Task<StudentModel[]> GetStudents();
        Task<StudentModel> GetStudent(int id);
        Task DeleteStudent(int id);
        Task AddStudent(StudentModel student);
        Task UpdateStudent(StudentModel student);
    }
}
