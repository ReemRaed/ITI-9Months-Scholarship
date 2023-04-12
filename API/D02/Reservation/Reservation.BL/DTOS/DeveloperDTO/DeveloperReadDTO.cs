using Reservation.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.BL.DTOS.DeveloperDTO
{
    public class DeveloperReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
       
    }
}
