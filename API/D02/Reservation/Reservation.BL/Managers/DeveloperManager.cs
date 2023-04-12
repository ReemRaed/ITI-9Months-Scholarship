using Reservation.BL.DTOS.DeveloperDTO;
using Reservation.BL.DTOS.TicketDTO;
using Reservation.DAL;
using Reservation.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.BL.Managers
{
    public class DeveloperManager : IDeveloperManager
    {
        private readonly IDeveloperRepo _developer;

        public DeveloperManager(IDeveloperRepo developer)
        {
            _developer = developer;
        }
        public void DeleteDeveloper(int id)
        {
            _developer.Delete(id);
        }

        public void postDeveloper(int Id, string Name)
        {
            Developer developer = new Developer();
            developer.Id = Id;
            developer.Name = Name;
            _developer.Insert(developer);
        }

        public IEnumerable<DeveloperReadDTO> ReadAll()
        {
            var DeveloperFromDB = _developer.GetAll();

            return DeveloperFromDB.Select(d => new DeveloperReadDTO
            {
                Id = d.Id,
                Name = d.Name
            });
        }

        public DeveloperReadDTO ReadById(int id)
        {
            DeveloperReadDTO Developer = new();
            var developer = _developer.GetDeveloper(id);
            Developer.Id = developer.Id;
            Developer.Name = developer.Name;
            return Developer;
        }

        public DeveloperReadDTO UpdateDeveloper(int id, DeveloperReadDTO DeveloperDTO)
        {
            var developer = _developer.GetDeveloper(id);
            developer.Id = DeveloperDTO.Id;
            developer.Name = DeveloperDTO.Name;

            _developer.Update(DeveloperDTO.Id, developer);
            return DeveloperDTO;
        }
    }
}
