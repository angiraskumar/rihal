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
    }
}
