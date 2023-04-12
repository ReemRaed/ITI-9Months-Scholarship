using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.BL.DTOS.DepartemntDTO;
using Reservation.BL.DTOS.DeveloperDTO;
using Reservation.BL.Managers;

namespace Reservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentManager _departmentManager;

        public DepartmentController(IDepartmentManager departmentManager)
        {
            _departmentManager = departmentManager;
        }

        [HttpGet]
        public ActionResult<List<DepartmentReadDTO>> GetAll()
        {
            return _departmentManager.ReadAll().ToList();
        }

        [HttpGet]
        [Route("id")]
        public ActionResult<DepartmentReadDTO> GetById(int id)
        {
            return _departmentManager.ReadById(id);
        }

        [HttpPut]
        public IActionResult Put(int id, DepartmentReadDTO departmentReadDTO)
        {
            return Ok(_departmentManager.UpdateDeveloper(id, departmentReadDTO));
        }

        [HttpPost]
        public void post(DepartmentReadDTO departmentReadDTO)
        {
            _departmentManager.postDepartment(departmentReadDTO.Id, departmentReadDTO.Name);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _departmentManager.DeleteDepartment(id);
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<DepartmentTicketDevelopers> GetDTV(int id)
        {
            //I need a method to take ID and return possible doctorReadDto
            DepartmentTicketDevelopers? department = _departmentManager.GetDetailsById(id);

            if (department is null)
            {
                return NotFound();
            }
            return department;
        }
    }
}
