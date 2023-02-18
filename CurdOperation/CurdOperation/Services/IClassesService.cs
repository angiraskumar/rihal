using CurdOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurdOperation.Services
{
    public interface IClassesService
    {
        Task<ClassesModel[]> GetClasses();
        Task<ClassesModel> GetClasses(int id);
        Task DeleteClasses(int id);
        Task AddClasses(ClassesModel employee);
        Task UpdateClasses(ClassesModel employee);
        Task<DashboardModel[]> GetDashboard();
    }
}
