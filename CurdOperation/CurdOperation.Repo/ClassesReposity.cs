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
        public Task<string> AddClasses(ClassesModel model)
        {

            try
            {
                using (var dbContext = new SqlLiteDBContext())
                {
                    //Ensure database is created
                     dbContext.Database.EnsureCreated();
                    int maxid = 0; 
                        if (dbContext.Classes.Any()){
                        maxid = dbContext.Classes.Max(z => z.ClassId);
                    }
                         dbContext.Classes.Add(
                              new Classes{ ClassId= maxid+1, ClassName= model.ClassName});
                         dbContext.SaveChanges();
                }
             }
            catch (Exception ex)
            {
                return Task.FromResult(ex.Message.ToString());
            }
            return Task.FromResult( "Success");
        }

        public Task DeleteClasses(int id)
        {
            throw new NotImplementedException();
        }

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
            IList<DashboardModel> model = new List<DashboardModel>();
            try
            {
                using (var dbContext = new SqlLiteDBContext())
                {

                    var result = dbContext.Student.GroupBy(z => z.ClassId).Select(z => new
                    {
                        key = z.Key,
                        cnt = z.Count()
                    }).ToList();

                    foreach(var item in result)
                    {
                        string classname = dbContext.Classes.Where(z => z.ClassId == item.key).FirstOrDefault()?.ClassName;
                        model.Add(new DashboardModel
                        {
                            Name = classname,
                            NoStudents=item.cnt
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
