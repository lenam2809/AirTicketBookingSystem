using AirTicketBookingSystem.DAL.DTOs;
using AirTicketBookingSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketBookingSystem.BLL
{
    public class FlightManager
    {
        private readonly IFlightRepository _flightRepository;

        public FlightManager(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public List<FlightDetailDTO> GetAllFlights()
        {
            return _flightRepository.GetAllFlights();
        }
    }
}
