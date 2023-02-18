using CurdOperation.Models;
using CurdOperation.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurdOperation.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;
        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }
        public Task AddStudent(StudentModel student)
        {
           return _repository.AddStudent(student);
        }

        public Task DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<StudentModel[]> GetStudents()
        {
            return _repository.GetStudents();
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
