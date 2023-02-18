using CurdOperation.Models;
using CurdOperation.Repo.Enitity;
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
            try
            {
                using (var dbContext = new SqlLiteDBContext())
                {
                    //Ensure database is created
                   /* dbContext.Database.EnsureCreated();
                    if (!dbContext.Classes.Any())
                    {
                        dbContext.Classes.AddRange(new Classes[]
                            {
                             new Classes{ ClassId=1, ClassName="I"},
                             new Classes{ClassId=2, ClassName="II" },
                             new Classes{ ClassId=3, ClassName="III"}
                            });
                        dbContext.SaveChanges();
                    }*/

                    foreach (var cls in dbContext.Classes)
                    {
                        model.Add(new ClassesModel
                        {
                            ClassId = cls.ClassId,
                            ClassName = cls.ClassName
                        });
                    }

                }
            }

            catch (Exception ex)
            {

            }


            
           
            return Task.FromResult(model.ToArray());
        }
    }
}
