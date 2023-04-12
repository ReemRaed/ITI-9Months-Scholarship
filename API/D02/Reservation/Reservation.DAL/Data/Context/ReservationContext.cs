using Microsoft.EntityFrameworkCore;
using Reservation.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DAL.Data.Context
{
    public class ReservationContext:DbContext
    {
        public ReservationContext(DbContextOptions<ReservationContext> options)
          : base(options)
        {

        }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Ticket> Tickets{ get; set; }

        public DbSet<Department> Departments { get; set; }   



    }
}
