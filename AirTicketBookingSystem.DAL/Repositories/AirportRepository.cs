using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketBookingSystem.DAL.Repositories
{
    public interface IAirportRepository
    {
        List<Airport> GetAirports();
        string GetIATACodeAirportById(int Id);
    }

    public class AirportRepository : IAirportRepository
    {
        private readonly AirTicketEntities _context;

        public AirportRepository(AirTicketEntities context)
        {
            _context = context;
        }
        public List<Airport> GetAirports()
        {
            return _context.Airports.ToList();
        }

        public string GetIATACodeAirportById(int Id)
        {
            var country = _context.Airports.Find(Id);

            if (country != null)
            {
                return country.IATACode;
            }

            return null;
        }
    }
}
