using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.BL.DTOS.TicketDTO
{
    public class TicketReadDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public int DepartmentId { get; set; }

    }

}
