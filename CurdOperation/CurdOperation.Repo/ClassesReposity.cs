using CurdOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurdOperation.Repo
{
    public class ClassesRepository : IClassesRepository
    {
        public Task<ClassesModel[]> GetClasses()
        {
            IList<ClassesModel> model = new List<ClassesModel>();
            model.Add(new ClassesModel
            {
                ClassId = 1,
                ClassName = "I"
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
    }
}
