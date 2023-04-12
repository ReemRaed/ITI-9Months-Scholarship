using Reservation.BL.DTOS.DepartemntDTO;
using Reservation.BL.DTOS.DeveloperDTO;
using Reservation.BL.DTOS.TicketDTO;
using Reservation.DAL;
using Reservation.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.BL.Managers
{
    public class DepartmentManager : IDepartmentManager
    {
        private readonly IDepartemntRepo _department;

        public DepartmentManager(IDepartemntRepo department)
        {
            _department = department;
        }
        public void DeleteDepartment(int id)
        {
            _department.Delete(id);
        }

        public DepartmentTicketDevelopers? GetDetailsById(int id)
        {
            Department? department = _department.GetWithDepartmnetWithdevelopers(id);

            if (department is null)
            {
                return null;
            }

            return new DepartmentTicketDevelopers
            {
                Id = department.Id,
                Name = department.Name,
                ticketsDevelopers = department.Ticket
                    .Select(p => new TicketsDevelopers
                    {
                        Id = p.Id,
                        Title = p.Title,
                        Description = p.Description,
                        DevelopersCount = p.Description.Count()
                    })
            };
        }

        public void postDepartment(int Id, string Name)
        {
            Department department = new Department();
            department.Id = Id;
            department.Name = Name;
            _department.Insert(department);

        }

        public IEnumerable<DepartmentReadDTO> ReadAll()
        {
            var DepartmentFromDB = _department.GetAll();

            return DepartmentFromDB.Select(d => new DepartmentReadDTO
            {
                Id = d.Id,
                Name = d.Name
            });
        }

        public DepartmentReadDTO ReadById(int id)
        {
            DepartmentReadDTO Department = new();
            var department = _department.GetDepartment(id);
            Department.Id = department.Id;
            Department.Name = department.Name;
            return Department;
        }

       public DepartmentReadDTO UpdateDeveloper(int id, DepartmentReadDTO Department)
        {

            var departemnt = _department.GetDepartment(id);
            departemnt.Id = Department.Id;
            departemnt.Name = Department.Name;
            _department.Update(Department.Id, departemnt);
            return Department;
        }
    }
}
