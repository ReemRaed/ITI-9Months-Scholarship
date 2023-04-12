using Reservation.BL.DTOS.TicketDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.BL.DTOS.DepartemntDTO
{
    public  class DepartmentTicketDevelopers
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public IEnumerable<TicketsDevelopers> ticketsDevelopers { get; init; }
            = new List<TicketsDevelopers>();

    }
}
