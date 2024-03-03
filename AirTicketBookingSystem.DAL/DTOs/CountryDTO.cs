using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketBookingSystem.DAL.DTOs
{
    public class CountryDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public CountryDTO()
        {

        }
        public CountryDTO(int idCountry, string namecoutry)
        {
            this.id = id;
            this.name = namecoutry;
        }
    }
}
