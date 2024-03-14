using AirTicketBookingSystem.DAL.Repositories;
using AirTicketBookingSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTicketBookingSystem.BLL.DTOs;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace AirTicketBookingSystem.BLL.Services
{
    public class BookingService
    {
        private readonly IRepository<User> customerRepository;
        private readonly IRepository<Airport> airportRepository;
        private readonly IRepository<Aircraft> aircraftRepository;
        private readonly IRepository<Country> countryRepository;
        private readonly IRepository<CabinType> cabinTypeRepository;
        private readonly AirticketBookingDatabaseEntities context;
        
        public BookingService()
        {
            this.context = new AirticketBookingDatabaseEntities();
            this.customerRepository = new Repository<User>(context);
            this.airportRepository = new Repository<Airport>(context);
            this.aircraftRepository = new Repository<Aircraft>(context);
            this.countryRepository = new Repository<Country>(context);
            this.cabinTypeRepository = new Repository<CabinType>(context);
        }

        public List<FlightDetailDTO> GetFlightOutbounds(int from, int to, int cabinType, DateTime date)
        {
            var result = new List<FlightDetailDTO>();
            var query = from route in context.Routes
                                            join schedule in context.Schedules on route.ID equals schedule.RouteID
                                            join arrivalAirport in context.Airports on route.ArrivalAirportID equals arrivalAirport.ID
                                            join departureAirport in context.Airports on route.DepartureAirportID equals departureAirport.ID
                                            where arrivalAirport.ID == @from && departureAirport.ID == @to && schedule.Date == @date
                                            select new
                                            {
                                                Route = route,
                                                Schedule = schedule,
                                                ArrivalAirport = arrivalAirport,
                                                DepartureAirport = departureAirport
                                            };

            foreach (var item in query)
            {
                var flightDetailDTO = new FlightDetailDTO
                {
                    ID = item.Schedule.ID,
                    Date = item.Schedule.Date,
                    FlightNumber = item.Schedule.FlightNumber,
                    From = item.ArrivalAirport.IATACode,
                    To = item.DepartureAirport.IATACode,
                    Time = item.Schedule.Time.ToString(),
                    CabinTypeId = cabinType,
                    EconomyPrice = item.Schedule.EconomyPrice,
                };
                result.Add(flightDetailDTO);
            }
            return result;
        }

        public List<FlightDetailDTO> GetFlightThreeDayOutbounds(int from, int to, int cabinType, DateTime date)
        {
            var result = new List<FlightDetailDTO>();
            var query = from route in context.Routes
                        join schedule in context.Schedules on route.ID equals schedule.RouteID
                        join arrivalAirport in context.Airports on route.ArrivalAirportID equals arrivalAirport.ID
                        join departureAirport in context.Airports on route.DepartureAirportID equals departureAirport.ID
                        where arrivalAirport.ID == @from && departureAirport.ID == @to && schedule.Date == @date
                        select new
                        {
                            Route = route,
                            Schedule = schedule,
                            ArrivalAirport = arrivalAirport,
                            DepartureAirport = departureAirport
                        };

            foreach (var item in query)
            {
                var flightDetailDTO = new FlightDetailDTO
                {
                    ID = item.Schedule.ID,
                    Date = item.Schedule.Date,
                    FlightNumber = item.Schedule.FlightNumber,
                    From = item.ArrivalAirport.IATACode,
                    To = item.DepartureAirport.IATACode,
                    Time = item.Schedule.Time.ToString(),
                    CabinTypeId = cabinType,
                    EconomyPrice = item.Schedule.EconomyPrice,
                };
                result.Add(flightDetailDTO);
            }
            return result;
        }
        public List<FlightDetailDTO> GetFlightReturns(int from, int to, int cabinType, DateTime dateOutbound, DateTime dateReturn)
        {
            var result = new List<FlightDetailDTO>();
            var query = from route in context.Routes
                        join schedule in context.Schedules on route.ID equals schedule.RouteID
                        join arrivalAirport in context.Airports on route.ArrivalAirportID equals arrivalAirport.ID
                        join departureAirport in context.Airports on route.DepartureAirportID equals departureAirport.ID
                        where arrivalAirport.ID == @from && departureAirport.ID == @to 
                        && schedule.Date >= @dateOutbound && schedule.Date <= @dateReturn
                        select new
                        {
                            Route = route,
                            Schedule = schedule,
                            ArrivalAirport = arrivalAirport,
                            DepartureAirport = departureAirport
                        };

            foreach (var item in query)
            {
                var flightDetailDTO = new FlightDetailDTO
                {
                    ID = item.Schedule.ID,
                    Date = item.Schedule.Date,
                    FlightNumber = item.Schedule.FlightNumber,
                    From = item.ArrivalAirport.IATACode,
                    To = item.DepartureAirport.IATACode,
                    Time = item.Schedule.Time.ToString(),
                    CabinTypeId = cabinType,
                    EconomyPrice = item.Schedule.EconomyPrice,
                };
                result.Add(flightDetailDTO);
            }
            return result;
        }

        public List<FlightDetailDTO> GetFlightThreeDayReturns(int from, int to, int cabinType, DateTime dateOutbound, DateTime dateReturn)
        {
            var result = new List<FlightDetailDTO>();
            var query = from route in context.Routes
                        join schedule in context.Schedules on route.ID equals schedule.RouteID
                        join arrivalAirport in context.Airports on route.ArrivalAirportID equals arrivalAirport.ID
                        join departureAirport in context.Airports on route.DepartureAirportID equals departureAirport.ID
                        where arrivalAirport.ID == @from && departureAirport.ID == @to
                        && schedule.Date >= @dateOutbound && schedule.Date <= @dateReturn
                        select new
                        {
                            Route = route,
                            Schedule = schedule,
                            ArrivalAirport = arrivalAirport,
                            DepartureAirport = departureAirport
                        };

            foreach (var item in query)
            {
                var flightDetailDTO = new FlightDetailDTO
                {
                    ID = item.Schedule.ID,
                    Date = item.Schedule.Date,
                    FlightNumber = item.Schedule.FlightNumber,
                    From = item.ArrivalAirport.IATACode,
                    To = item.DepartureAirport.IATACode,
                    Time = item.Schedule.Time.ToString(),
                    CabinTypeId = cabinType,
                    EconomyPrice = item.Schedule.EconomyPrice,
                };
                result.Add(flightDetailDTO);
            }
            return result;
        }

        public List<UserDTO> GetAllUsers()
        {
            var result = new List<UserDTO>();
            var users = customerRepository.GetAll();
            foreach (var item in users)
            {
                var userDTO = new UserDTO
                {
                    ID = item.ID,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Active = item.Active,
                    Birthdate = item.Birthdate,
                    Email = item.Email
                };
                result.Add(userDTO);
            }
            return result;
        }

        public List<CabinTypeDTO> GetAllCabinTypes()
        {
            var result = new List<CabinTypeDTO>();
            var cabinTypes = cabinTypeRepository.GetAll();
            foreach (var item in cabinTypes)
            {
                var cabinTypeDTO = new CabinTypeDTO
                {
                    ID = item.ID,
                    Name = item.Name
                };
                result.Add(cabinTypeDTO);
            }
            return result;
        }

        public List<AirportDTO> GetAllAirports()
        {
            var result = new List<AirportDTO>();
            var airports = airportRepository.GetAll();
            foreach (var item in airports)
            {
                var airportDTO = new AirportDTO
                {
                    ID = item.ID,
                    CountryID = item.CountryID,
                    IATACode = item.IATACode,
                    Name = item.Name
                };
                result.Add(airportDTO);
            }
            return result;
        }
    }
}
