﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DAL.Data.Models
{
    public  class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public IEnumerable<Ticket> Ticket { get; set; } = new HashSet<Ticket>();
    }
}
