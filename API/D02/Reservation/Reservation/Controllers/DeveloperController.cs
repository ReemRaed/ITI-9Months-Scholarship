using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.BL.DTOS.DeveloperDTO;
using Reservation.BL.DTOS.TicketDTO;
using Reservation.BL.Managers;
using Reservation.DAL;

namespace Reservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly IDeveloperManager _developerManager;

        public DeveloperController(IDeveloperManager developerManager)
        {
            _developerManager = developerManager;
        }

        [HttpGet]
        public ActionResult<List<DeveloperReadDTO>> GetAll()
        {
            return _developerManager.ReadAll().ToList();
        }

        [HttpGet]
        [Route("id")]
        public ActionResult<DeveloperReadDTO> GetById(int id)
        {
            return _developerManager.ReadById(id);
        }

        [HttpPut]
        public IActionResult Put(int id, DeveloperReadDTO developerRead)
        {
            return Ok(_developerManager.UpdateDeveloper(id, developerRead));
        }

        [HttpPost]
        public void post(DeveloperReadDTO developerReadDTO)
        {
            _developerManager.postDeveloper(developerReadDTO.Id,developerReadDTO.Name);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _developerManager.DeleteDeveloper(id);
        }


    }
}
