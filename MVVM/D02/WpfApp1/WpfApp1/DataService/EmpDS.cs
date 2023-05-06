using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DAL;
using WpfApp1.Models;

namespace WpfApp1.DataService
{
    public class EmpDS : IEmpDS
    {
        public void Add(Employee emp)
        {
            using (EmpDBContext Context = new())
            {
                if (emp != null)
                    Context.Employees.Add(emp);
                Context.SaveChanges();

            }
        }

        public void Delete(int id)
        {
            using (EmpDBContext empDBContext = new EmpDBContext())
            {
                var Employee = empDBContext.Employees.FirstOrDefault(s => s.Id == id);
                if (Employee != null)
                    empDBContext.Employees.Remove(Employee);
                empDBContext.SaveChanges();
            }
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            using (EmpDBContext dbContext = new EmpDBContext())
            {
                dbContext.Database.EnsureCreated();
                return  dbContext.Employees.ToList();
            }
             
        }

        public void Update(Employee emp)
        {
            using (EmpDBContext Context = new())
            {
                var EmployeeUpdate = Context.Employees.FirstOrDefault(s => s.Id == emp.Id);
                if (EmployeeUpdate != null)
                {
                    EmployeeUpdate.FirstName = emp.FirstName;
                    EmployeeUpdate.LastName = emp.LastName;
                    EmployeeUpdate.Grade = emp.Grade;
                    Context.SaveChanges();
                }

            }
        }
    }
}
