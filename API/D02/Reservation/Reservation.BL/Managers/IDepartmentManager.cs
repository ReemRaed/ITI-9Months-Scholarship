using Reservation.BL.DTOS.DepartemntDTO;
using Reservation.BL.DTOS.DeveloperDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.BL.Managers
{
    public interface IDepartmentManager
    {
        IEnumerable<DepartmentReadDTO> ReadAll();
        DepartmentReadDTO ReadById(int id);

        DepartmentReadDTO UpdateDeveloper(int id, DepartmentReadDTO Department);

        void DeleteDepartment(int id);

        void postDepartment(int Id, string Name);

        public DepartmentTicketDevelopers? GetDetailsById(int id);
    }
}
