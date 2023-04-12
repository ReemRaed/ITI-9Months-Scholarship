using Microsoft.EntityFrameworkCore;
using Reservation.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Reservation.DAL;

public interface ITicketRepo
{
    void Insert(Ticket ticket);
     IEnumerable<Ticket> GetAll();

     Ticket GetTicket(int id);

     void Delete(int id);

     void Update(int id, Ticket updatedTicket);



}

