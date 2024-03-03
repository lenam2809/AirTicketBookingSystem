using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketBookingSystem.DAL.Repositories
{
    public interface ITicketRepository
    {
        List<Ticket> GetTickets();
        void AddTicket(Ticket ticket);
        bool CheckBookingExist(string booking);
    }

    public class TicketRepository : ITicketRepository
    {
        private readonly AirTicketEntities _context;

        public TicketRepository(AirTicketEntities context)
        {
            _context = context;
        }
        public List<Ticket> GetTickets()
        {
            return _context.Tickets.ToList();
        }

        public void AddTicket(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }

        public bool CheckBookingExist(string booking)
        {
            return _context.Tickets.Any(t => t.BookingReference == booking);
        }
    }
}
