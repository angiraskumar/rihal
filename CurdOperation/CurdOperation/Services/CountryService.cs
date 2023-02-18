using CurdOperation.Models;
using CurdOperation.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurdOperation.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _repository;
        public CountryService(ICountryRepository repository)
        {
            _repository = repository;
        }
        public Task AddCountry(CountryModel country)
        {
            return _repository.AddCountry(country);
        }

        public Task DeleteCountry(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CountryModel[]> GetCountries()
        {
            return _repository.GetCountries();
        }

        public Task<CountryModel> GetCountry(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCountry(CountryModel country)
        {
            throw new NotImplementedException();
        }
        public Task<DashboardModel[]> GetDashboard()
        {
            return _repository.GetDashboard();
        }
    }
}
