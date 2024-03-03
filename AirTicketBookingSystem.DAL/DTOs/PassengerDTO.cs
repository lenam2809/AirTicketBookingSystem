using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketBookingSystem.DAL.DTOs
{
    public class PassengerDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string PassportNumber { get; set; }
        public string PassporCountry { get; set; }
        public string Phone { get; set; }
        public PassengerDTO()
        {

        }
        public PassengerDTO(string fn, string ln, string bd, string pn, string pc, string p)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.Birthday = bd;
            this.PassportNumber = pn;
            this.PassporCountry = pc;
            this.Phone = p;
        }
    }
}
