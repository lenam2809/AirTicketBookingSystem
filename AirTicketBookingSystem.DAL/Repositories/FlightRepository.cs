using AirTicketBookingSystem.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketBookingSystem.DAL.Repositories
{
    public interface IFlightRepository
    {
        List<FlightDetailDTO> GetFlights(int? from, int? to, DateTime? date);
        List<FlightDetailDTO> GetAllFlights();
        List<FlightDetailDTO> GetFlightReturn(int? from, int? to, DateTime? dateOutbound, DateTime? dateReturn);
        List<FlightDetailDTO> GetFlightThreeDaysOutbound(int? from, int? to, DateTime? date);

        List<FlightDetailDTO> GetFlightThreeDaysReturn(int? from, int? to, DateTime? dateOutbound, DateTime? dateReturn);
        int GetPassengers(int idSchedule);

        int GetTotalSeatsDefault(int idSchedule);

        int GetEconomySeatsDefault(int idSchedule);

        int GetBusinessSeatsDefault(int idSchedule);

        int getTotalSeats(int idSchedule);
        int getEconomySeats(int idSchedule);
        int getBusinessSeats(int idSchedule);
        List<FlightDetailDTO> GetFlightFrom(int idAirportFrom, string date);
        List<FlightDetailDTO> getFlightTo(int idAirportTo, string date);
        List<FlightDetailDTO> getFlightFromThreeday(int idAirportFrom, string date);
        List<FlightDetailDTO> getFlightToThreeday(int idAirportTo, string date);
    }

    public class FlightRepository : IFlightRepository
    {
        private readonly AirTicketEntities _context;

        public FlightRepository(AirTicketEntities context)
        {
            _context = context;
        }

        public List<FlightDetailDTO> GetAllFlights()
        {
            List<FlightDetailDTO> flights = new List<FlightDetailDTO>();
            var result = _context.Schedules
                        .Join(
                            _context.Routes,
                            schedule => schedule.RouteID,
                            route => route.ID,
                            (schedule, route) => new { schedule, route }
                        );
            foreach (var item in result)
            {
                FlightDetailDTO flightDetail = new FlightDetailDTO(item.route.DepartureAirportID, item.route.ArrivalAirportID, item.schedule.Date, item.schedule.Time.ToString(), item.schedule.FlightNumber, item.schedule.EconomyPrice.ToString(), 0);
                flights.Add(flightDetail);
            }


            return flights;
        }

        public int getBusinessSeats(int idSchedule)
        {
            throw new NotImplementedException();
        }

        public int GetBusinessSeatsDefault(int idSchedule)
        {
            throw new NotImplementedException();
        }

        public int getEconomySeats(int idSchedule)
        {
            throw new NotImplementedException();
        }

        public int GetEconomySeatsDefault(int idSchedule)
        {
            throw new NotImplementedException();
        }

        public List<FlightDetailDTO> GetFlight(int? from, int? to, DateTime? date)
        {
            List<FlightDetailDTO> flights = new List<FlightDetailDTO>();
            var result = _context.Schedules
                        .Join(
                            _context.Routes,
                            schedule => schedule.RouteID,
                            route => route.ID,
                            (schedule, route) => new { schedule, route }
                        )
                        .Where(x => x.route.DepartureAirportID == from 
                            && x.route.ArrivalAirportID == to 
                            && x.schedule.Date == date)
                        .Select(x => x.schedule);
            foreach(var item in result) 
            {
                FlightDetailDTO flightDetail = new FlightDetailDTO(from, to, item.Date, item.Time.ToString(), item.FlightNumber, item.EconomyPrice.ToString(), 0);
                flights.Add(flightDetail);
            }


            return flights;
        }

        public List<FlightDetailDTO> GetFlightFrom(int idAirportFrom, string date)
        {
            throw new NotImplementedException();
        }

        public List<FlightDetailDTO> getFlightFromThreeday(int idAirportFrom, string date)
        {
            throw new NotImplementedException();
        }

        public List<FlightDetailDTO> GetFlightReturn(int? from, int? to, DateTime? dateOutbound, DateTime? dateReturn)
        {
            throw new NotImplementedException();
        }

        public List<FlightDetailDTO> GetFlights(int? from, int? to, DateTime? date)
        {
            throw new NotImplementedException();
        }

        public List<FlightDetailDTO> GetFlightThreeDaysOutbound(int? from, int? to, DateTime? date)
        {
            throw new NotImplementedException();
        }

        public List<FlightDetailDTO> GetFlightThreeDaysReturn(int? from, int? to, DateTime? dateOutbound, DateTime? dateReturn)
        {
            throw new NotImplementedException();
        }

        public List<FlightDetailDTO> getFlightTo(int idAirportTo, string date)
        {
            throw new NotImplementedException();
        }

        public List<FlightDetailDTO> getFlightToThreeday(int idAirportTo, string date)
        {
            throw new NotImplementedException();
        }

        public int GetPassengers(int idSchedule)
        {
            throw new NotImplementedException();
        }

        public int getTotalSeats(int idSchedule)
        {
            throw new NotImplementedException();
        }

        public int GetTotalSeatsDefault(int idSchedule)
        {
            throw new NotImplementedException();
        }
    }
}
