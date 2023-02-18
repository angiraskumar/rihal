using CurdOperation.Models;
using CurdOperation.Repo.Enitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurdOperation.Repo
{
    public class CountryRepository : ICountryRepository
    {
        public Task<string> AddCountry(CountryModel model)
        {
            try
            {
                using (var dbContext = new SqlLiteDBContext())
                {
                    //Ensure database is created
                    dbContext.Database.EnsureCreated();
                    int maxid = 0;
                    if (dbContext.Country.Any())
                    {
                        maxid = dbContext.Country.Max(z => z.CountryId);
                    }
                    dbContext.Country.Add(
                         new Country { CountryId = maxid + 1, CountryName = model.CountryName });
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return Task.FromResult(ex.Message.ToString());
            }
            return Task.FromResult("Success");
        }

        public Task DeleteCountry(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CountryModel[]> GetCountries()
        {
            IList<CountryModel> model = new List<CountryModel>();
            try
            {
               
                using (var dbContext = new SqlLiteDBContext())
                {
                    

                    foreach (var cls in dbContext.Country)
                    {
                        model.Add(new CountryModel
                        {
                            CountryId = cls.CountryId,
                            CountryName = cls.CountryName
                        });
                    }

                }
            }

            catch (Exception ex)
            {

            }
            return Task.FromResult(model.ToArray());
        }

        public Task<CountryModel> GetCountry(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCountry(CountryModel model)
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

                    var result = dbContext.Student.GroupBy(z => z.CountryId).Select(z => new
                    {
                        key = z.Key,
                        cnt = z.Count()
                    }).ToList();

                    foreach (var item in result)
                    {
                        string classname = dbContext.Country.Where(z => z.CountryId == item.key).FirstOrDefault()?.CountryName;
                        model.Add(new DashboardModel
                        {
                            Name = classname,
                            NoStudents = item.cnt
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
