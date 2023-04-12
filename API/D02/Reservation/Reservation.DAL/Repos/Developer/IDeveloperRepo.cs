using Reservation.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DAL
{
    public interface IDeveloperRepo
    {
        void Insert(Developer developer);
        IEnumerable<Developer> GetAll();

        Developer GetDeveloper(int id);

        void Delete(int id);

        void Update(int id, Developer updatedDeveloper);
    }
}
