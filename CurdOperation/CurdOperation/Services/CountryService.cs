using CurdOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurdOperation.Services
{
    public class CountryService : ICountryService
    {
        public Task AddCountry(CountryModel country)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCountry(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CountryModel>> GetCountry()
        {
            throw new NotImplementedException();
        }

        public Task<CountryModel> GetCountry(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCountry(CountryModel country)
        {
            throw new NotImplementedException();
        }
    }
}
