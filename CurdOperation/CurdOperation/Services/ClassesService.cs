using CurdOperation.Models;
using CurdOperation.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurdOperation.Services
{
    public class ClassesService : IClassesService
    {

        private readonly IClassesRepository _repository;
        public ClassesService(IClassesRepository repository)
        {
            _repository = repository;
        }
        public  Task AddClasses(ClassesModel model)
        {
            return _repository.AddClasses( model);
        }

        public Task DeleteClasses(int id)
        {
            throw new NotImplementedException();
        }

        public  Task<ClassesModel[]> GetClasses()
        {
            
            return _repository.GetClasses();
        }

        public Task<ClassesModel> GetClasses(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateClasses(ClassesModel employee)
        {
            throw new NotImplementedException();
        }
        public Task<DashboardModel[]> GetDashboard()
        {
            return _repository.GetDashboard();
        }
    }
}
