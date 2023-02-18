using CurdOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurdOperation.Services
{
    public class ClassesService : IClassesService
    {
       
        public ClassesService()
        {
           
        }
        public  Task AddClasses(ClassesModel employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteClasses(int id)
        {
            throw new NotImplementedException();
        }

        public  Task<ClassesModel[]> GetClasses()
        {
            IList<ClassesModel> model = new List<ClassesModel>();
            model.Add(new ClassesModel
            {
                ClassId=1,
                ClassName="I"
            });
            model.Add(new ClassesModel
            {
                ClassId = 2,
                ClassName = "II"
            });
            model.Add(new ClassesModel
            {
                ClassId = 1,
                ClassName = "III"
            });
            model.Add(new ClassesModel
            {
                ClassId = 1,
                ClassName = "IV"
            });
            model.Add(new ClassesModel
            {
                ClassId = 1,
                ClassName = "V"
            });

            return Task.FromResult(model.ToArray());
        }

        public Task<ClassesModel> GetClasses(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateClasses(ClassesModel employee)
        {
            throw new NotImplementedException();
        }
    }
}
