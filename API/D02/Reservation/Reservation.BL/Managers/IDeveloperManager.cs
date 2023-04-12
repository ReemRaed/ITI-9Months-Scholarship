using Reservation.BL.DTOS.DeveloperDTO;
using Reservation.BL.DTOS.TicketDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.BL.Managers
{
    public interface IDeveloperManager
    {
        IEnumerable<DeveloperReadDTO> ReadAll();
        DeveloperReadDTO ReadById(int id);

        DeveloperReadDTO UpdateDeveloper(int id, DeveloperReadDTO Developer);

        void DeleteDeveloper(int id);

        void postDeveloper(int Id, string Name);

    }
}
