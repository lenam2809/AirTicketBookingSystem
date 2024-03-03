using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketBookingSystem.DAL.DTOs
{
    public class FlightDetailDTO
    {
        public int ID { get; set; }
        public int? From { get; set; }
        public int? To { get; set; }
        public DateTime? Date { get; set; }
        public string Time { get; set; }
        public string flightNumber { get; set; }
        public string cabinPrice { get; set; }
        public int numberOfStop { get; set; }
        public FlightDetailDTO()
        {

        }
        public FlightDetailDTO(int? from, int? to, DateTime? date, string time, string fn, string carbin, int numstop)
        {
            this.From = from;
            this.To = to;
            this.Date = date;
            this.Time = time;
            this.flightNumber = fn;
            this.cabinPrice = carbin;
            this.numberOfStop = numstop;
        }
        public double getRealPrice(int idCabin)
        {
            double price = 0;
            if (idCabin == 1)
            {
                price = Convert.ToDouble(cabinPrice);
            }
            if (idCabin == 2)
            {
                price = Convert.ToDouble(cabinPrice) * 1.35;
            }
            if (idCabin == 3)
            {
                price = Convert.ToDouble(cabinPrice) * 1.35 * 1.3;
            }
            return price;
        }
    }
}
