using Microsoft.EntityFrameworkCore;
using Reservation.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DAL
{
    public interface IDepartemntRepo
    {
        void Insert(Department department);
        IEnumerable<Department> GetAll();

        Department GetDepartment(int id);

        void Delete(int id);
        void Update(int id, Department updatedDepartment);

        public Department? GetWithDepartmnetWithdevelopers(int id);
       
    }
}
