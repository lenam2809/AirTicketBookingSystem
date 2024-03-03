using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketBookingSystem.DAL.DTOs
{
    public class CabinTypesDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CabinTypesDTO()
        {

        }
        public CabinTypesDTO(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
