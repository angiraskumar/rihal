using CurdOperation.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CurdOperation.Repo
{
    public interface ICountryRepository
    {
        Task<CountryModel[]> GetCountries();
        Task<CountryModel> GetCountry(int id);
        Task DeleteCountry(int id);
        Task<string> AddCountry(CountryModel model);
        Task UpdateCountry(CountryModel model);
        Task<DashboardModel[]> GetDashboard();
    }
}
