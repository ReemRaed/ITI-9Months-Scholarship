using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.DataService
{
    public interface IEmpDS
    {
        public IEnumerable<Employee> GetAll();
        Employee Get(int id);
        void Add(Employee student);
        void Update(Employee student);
        void Delete(int id);
    }
}
