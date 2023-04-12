using Microsoft.EntityFrameworkCore;
using Reservation.DAL.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DAL.Repos.Ticket
{
    public class TicketRepo : ITicketRepo
    {

        private readonly ReservationContext _context;

        public TicketRepo(ReservationContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var Ticket = _context.Tickets.Find(id);
            _context.Tickets.Remove(Ticket);
            _context.SaveChanges();
        }

        public IEnumerable<Data.Models.Ticket> GetAll()
        {
            return _context.Tickets.Include(e=>e.Department).Include(e=>e.Developers).ToList();
        }

        public Data.Models.Ticket GetTicket(int id)
        {
            return _context.Tickets.Where(e => e.Id == id).FirstOrDefault();
        }

        public void Insert(Data.Models.Ticket ticket)
        {
                _context.Tickets.Add(ticket);
                _context.SaveChanges();
         
        }

        public void Update(int id, Data.Models.Ticket updatedTicket)
        {
            var ticket = _context.Tickets.Find(id);
            if (ticket != null)
            {
                ticket.Title=updatedTicket.Title;
                ticket.Description = updatedTicket.Description;
                ticket.DepartmentId = updatedTicket.DepartmentId;
                _context.SaveChangesAsync();

            }
        }
    }
}
