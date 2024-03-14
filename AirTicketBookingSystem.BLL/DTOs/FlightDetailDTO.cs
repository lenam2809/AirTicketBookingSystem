using System;
using System.Diagnostics;

namespace AirTicketBookingSystem.BLL.DTOs
{
    public class FlightDetailDTO
    {
        public int ID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime? Date { get; set; }
        public string Time { get; set; }
        public string FlightNumber { get; set; }
        public int CabinTypeId { get; set; }
        public string CabinTypeName { get; set; }
        public decimal EconomyPrice { get; set; }

        public decimal CabinPrice
        {
            get
            {
                if (CabinTypeId == 2)
                {
                    return EconomyPrice * 1.35m; 
                }
                else if (CabinTypeId == 3)
                {
                    return EconomyPrice * 1.35m * 1.3m; 
                }
                else
                {
                    return EconomyPrice;
                }
            }
        }
        public int NumberOfStop { get; set; }
        public FlightDetailDTO()
        {

        }
    }
}
