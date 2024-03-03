using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketBookingSystem.DAL.DTOs
{
    public class AirportsDTO
    {
        public int ID { get; set; }
        public int CountryID { get; set; }
        public string IATACode { get; set; }
        public string Name { get; set; }
        public AirportsDTO()
        {

        }
        public AirportsDTO(int id, int idCountry, string code, string name)
        {
            this.ID = id;
            this.CountryID = idCountry;
            this.IATACode = code;
            this.Name = name;
        }
    }
}
