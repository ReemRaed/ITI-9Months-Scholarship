using Microsoft.EntityFrameworkCore;
using Reservation.DAL.Data.Context;
using Reservation.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DAL;
  public  class DeveloperRepo : IDeveloperRepo
{
    private readonly ReservationContext _context;

    public DeveloperRepo(ReservationContext context)
    {
        _context = context;
    }
    public void Delete(int id)
    {
        var  Developer = _context.Developers.Find(id);
        _context.Developers.Remove(Developer);
        _context.SaveChanges();
    }

    public IEnumerable<Data.Models. Developer> GetAll()
    {
        return _context.Developers.Include(e=>e.Ticket).ToList();
    }



    public Data.Models.Developer GetDeveloper(int id)
    {
        return _context.Developers.Find(id);
    }

    public void Insert(Data.Models.Developer developer)
    {
        _context.Developers.Add(developer);
        _context.SaveChanges();

    }

    public void Update(int id, Data.Models.Developer updatedDeveloper)
    {
        var developer = _context.Developers.Find(id);
        if (developer != null)
        {
            developer.Name = updatedDeveloper.Name;
            _context.SaveChanges();
        }
    }


}

