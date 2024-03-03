using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketBookingSystem.DAL.Repositories
{
    public interface ICountryRepository
    {
        List<Country> GetCountries();
        string GetNameCountryById(int countryId);
    }

    public class CountryRepository : ICountryRepository
    {
        private readonly AirTicketEntities _context;

        public CountryRepository(AirTicketEntities context)
        {
            _context = context;
        }
        public List<Country> GetCountries()
        {
            return _context.Countries.ToList();
        }

        public string GetNameCountryById(int countryId)
        {
            var country = _context.Countries.Find(countryId);

            if (country != null)
            {
                return country.Name; 
            }

            return null; 
        }
    }
}
