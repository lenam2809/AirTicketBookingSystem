using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketBookingSystem.DAL.Repositories
{
    public interface ICabinTypeRepository
    {
        List<CabinType> GetCabinTypes();
        string GetNameCabinTypeById(int Id);
    }

    public class CabinTypeRepository : ICabinTypeRepository
    {
        private readonly AirTicketEntities _context;

        public CabinTypeRepository(AirTicketEntities context)
        {
            _context = context;
        }
        public List<CabinType> GetCabinTypes()
        {
            return _context.CabinTypes.ToList();
        }

        public string GetNameCabinTypeById(int Id)
        {
            var country = _context.CabinTypes.Find(Id);

            if (country != null)
            {
                return country.Name;
            }

            return null;
        }
    }
}
