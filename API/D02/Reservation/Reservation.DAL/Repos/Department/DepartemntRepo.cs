using Microsoft.EntityFrameworkCore;
using Reservation.DAL.Data.Context;
using Reservation.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DAL
{
    public class DepartemntRepo : IDepartemntRepo
    {

        private readonly ReservationContext _context;

        public DepartemntRepo(ReservationContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var Department = _context.Departments.Find(id);
            _context.Departments.Remove(Department);
            _context.SaveChanges();
        }

        public IEnumerable<Data.Models.Department> GetAll()
        {
            return _context.Departments.Include(e=>e.Ticket).ToList();
        }

        public Data.Models.Department GetDepartment(int id)
        {
            return _context.Departments.Find(id);
        }

        public Department? GetWithDepartmnetWithdevelopers(int id)
        {
            
                return _context.Set<Department>()
                        .Include(d => d.Ticket)
                            .ThenInclude(p => p.Developers)
                        .FirstOrDefault(d => d.Id == id);
            
        }

        public void Insert(Data.Models.Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();

        }

        public void Update(int id, Data.Models.Department updatedDepartment)
        {
            var department = _context.Departments.Find(id);
            if (department != null)
            {
                department.Name= updatedDepartment.Name;
                _context.SaveChanges();
            }
        }
    }
}
