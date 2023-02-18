using CurdOperation.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CurdOperation.Repo
{
    public interface IStudentRepository
    {
        Task<StudentModel[]> GetStudents();
        Task<StudentModel> GetStudent(int id);
        Task DeleteStudent(int id);
        Task<string> AddStudent(StudentModel model);
        Task UpdateStudent(StudentModel model);
    }
}
