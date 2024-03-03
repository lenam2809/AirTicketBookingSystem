using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketBookingSystem.DAL.DTOs
{
    public class AircraftDTO
    {
        public int ID { get; set; }
        public int totalSeat { get; set; }
        public int EconomySeat { get; set; }
        public int BusinessSeat { get; set; }
        public int FirstClassSeat { get; set; }

        public AircraftDTO()
        {

        }
        public AircraftDTO(int idAircraft, int total, int Economy, int Bussiness)
        {
            this.ID = idAircraft;
            this.totalSeat = total;
            this.EconomySeat = Economy;
            this.BusinessSeat = Bussiness;
            this.FirstClassSeat = total - Economy - Bussiness;
        }
    }
}
