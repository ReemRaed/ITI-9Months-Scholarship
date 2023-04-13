using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly UserManager<Employee> _userManager;

        public DataController(UserManager<Employee> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        [Route("User")]
        [Authorize(Policy = "AllowUser")]
        public ActionResult GetDataForAdmins()
        {
            return Ok(new { Data = "This data is secured" });
        }

        [HttpGet]
        [Route("Managers")]
        [Authorize(Policy = "AllowManagers")]
        public async Task<ActionResult> GetDataForEngineers()
        {
            var user = await _userManager.GetUserAsync(User);
            return Ok(new { Data = "This data is secured" });
        }
    }
}
