using Reservation.BL.DTOS.TicketDTO;
using Reservation.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.DAL.Repos.Ticket;
using Reservation.DAL.Data.Models;
using System.Net.Sockets;

namespace Reservation.BL.Managers
{
    public class TicketManager : ITicketManager
    {
        private readonly ITicketRepo _ticket;

        public TicketManager(ITicketRepo ticket)
        {
            _ticket = ticket;
        }

        public void DeleteTicket(int id)
        {
          _ticket.Delete(id);
        }
        public void  postTicket(int Id,string Description, string Title, int  DepartmentId)
        {
            var ticket = new Ticket();
            ticket.Id = Id;
            ticket.Description = Description;
            ticket.Title = Title;
            ticket.DepartmentId = DepartmentId;
            _ticket.Insert(ticket);

        }
    public IEnumerable<TicketReadDTO> ReadAll()
    {
        var ticketFromDB = _ticket.GetAll();

            return ticketFromDB.Select(d => new TicketReadDTO {
                  Id= d.Id,
                    Description= d.Description,
                   Title= d.Title
                    , DepartmentId= d.DepartmentId
                });
           
        }

        public TicketReadDTO ReadById(int id)
        {
            TicketReadDTO ticket = new();
            var  Ticket=_ticket.GetTicket(id);
            ticket.Id = Ticket.Id;
            ticket.Description=Ticket.Description;
            ticket.Title = Ticket.Title;
            ticket.DepartmentId= Ticket.DepartmentId;
            return ticket;

  
        }

        public TicketReadDTO UpdateTicket(int id,TicketReadDTO ticketReadDTO) 
        {
            var Ticket = _ticket.GetTicket(id);
            Ticket.Description = ticketReadDTO.Description;
            Ticket.Title = ticketReadDTO.Title;
            Ticket.DepartmentId = ticketReadDTO.DepartmentId;
             _ticket.Update(ticketReadDTO.Id, Ticket);

            return ticketReadDTO;
        }

    }
}
