using CurdOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurdOperation.Services
{
    public interface ICountryService
    {
        Task<CountryModel[]> GetCountries();
        Task<CountryModel> GetCountry(int id);
        Task DeleteCountry(int id);
        Task AddCountry(CountryModel country);
        Task UpdateCountry(CountryModel country);
        Task<DashboardModel[]> GetDashboard();
    }
}
