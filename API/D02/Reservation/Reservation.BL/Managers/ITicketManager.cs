using Reservation.BL.DTOS.TicketDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.BL.Managers
{
    public interface ITicketManager
    {
        IEnumerable<TicketReadDTO> ReadAll();
        TicketReadDTO ReadById(int id);

        TicketReadDTO UpdateTicket(int id, TicketReadDTO ticket);

        void DeleteTicket(int id);

        void postTicket(int Id, string Description, string Title, int DepartmentId);

    }
}
