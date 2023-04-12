using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.BL.DTOS.TicketDTO;
using Reservation.BL.Managers;

namespace Reservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketManager _ITicketManager;

        public TicketController(ITicketManager ITicketManager)
        {
            _ITicketManager = ITicketManager;
        }

        [HttpGet]
        public ActionResult<List<TicketReadDTO>> GetAll()
        {
            return _ITicketManager.ReadAll().ToList();
        }

        [HttpGet]
        [Route("id")]
        public ActionResult<TicketReadDTO> GetById(int id)
        {
            return _ITicketManager.ReadById(id);
        }

        [HttpPut]
        public IActionResult Put(int id,TicketReadDTO ticket)
        {
            return Ok(_ITicketManager.UpdateTicket(id, ticket));
        }

         [HttpPost]
        public void  post(TicketReadDTO ticket)
        {
           _ITicketManager.postTicket(ticket.Id,ticket.Description,ticket.Title,ticket.DepartmentId);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _ITicketManager.DeleteTicket(id);
        }

    }
}
