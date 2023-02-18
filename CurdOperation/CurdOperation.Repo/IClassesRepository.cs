using CurdOperation.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CurdOperation.Repo
{
    public interface IClassesRepository
    {
        Task<ClassesModel[]> GetClasses();
        Task<ClassesModel> GetClasses(int id);
        Task DeleteClasses(int id);
        Task<string> AddClasses(ClassesModel model);
        Task UpdateClasses(ClassesModel model);
        Task<DashboardModel[]> GetDashboard();
    }
}
