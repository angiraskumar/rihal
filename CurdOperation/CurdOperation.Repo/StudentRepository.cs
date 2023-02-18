using CurdOperation.Models;
using CurdOperation.Repo.Enitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurdOperation.Repo
{
    public class StudentRepository : IStudentRepository
    {
        public Task<string> AddStudent(StudentModel model)
        {
            try
            {
                using (var dbContext = new SqlLiteDBContext())
                {
                    //Ensure database is created
                    dbContext.Database.EnsureCreated();
                    int maxid = 0;
                    if (dbContext.Student.Any())
                    {
                        maxid = dbContext.Student.Max(z => z.StudentId);
                    }
                    dbContext.Student.Add(
                         new Student { StudentId = maxid + 1,
                            StudentName = model.StudentName,
                            CountryId= Convert.ToInt32( model.CountryId),
                            ClassId= Convert.ToInt32(model.ClassId)
                         });
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return Task.FromResult(ex.Message.ToString());
            }
            return Task.FromResult("Success");
        }

        public Task DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<StudentModel> GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<StudentModel[]> GetStudents()
        {
            IList<StudentModel> model = new List<StudentModel>();
            try
            {

                using (var dbContext = new SqlLiteDBContext())
                {


                    foreach (var cls in dbContext.Student)
                    {
                        string countryname = dbContext.Country.Where(z => z.CountryId == cls.CountryId).FirstOrDefault()?.CountryName;
                        string classname = dbContext.Classes.Where(z => z.ClassId == cls.ClassId).FirstOrDefault()?.ClassName;
                        model.Add(new StudentModel
                        {
                            CountryId = cls.CountryId.ToString(),
                            StudentName = cls.StudentName,
                            StudentId=cls.StudentId,
                            ClassId=cls.ClassId.ToString(),
                            CountryName= countryname,
                            ClassName = classname,
                            LastDate =cls.ModifiedDate.ToString("dd-MMM-yyyy")
                        });
                    }

                }
            }

            catch (Exception ex)
            {

            }
            return Task.FromResult(model.ToArray());
        }

        public Task UpdateStudent(StudentModel model)
        {
            throw new NotImplementedException();
        }
    }
}
