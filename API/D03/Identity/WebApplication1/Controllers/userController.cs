using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication1.Data;
using WebApplication1.DTOS;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly IConfiguration _configuration; //catch Secret Key
        private readonly UserManager<Employee> _userManager;

        public userController(IConfiguration configuration,
            UserManager<Employee> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }

        [HttpPost]
        [Route("Register")]

        public  async  Task<IActionResult> Register (RegisterDTO registerDTO)
        {
            var newEmployee = new Employee
            {
                UserName = registerDTO.Username,
                Email = registerDTO.Email,
                Department = registerDTO.Department,
            };

            var Result = await _userManager.CreateAsync(newEmployee, registerDTO.Password);

            if (!Result.Succeeded) return BadRequest(Result.Errors);

            const string Role= "User";

            var Claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,(newEmployee.Id)),
                new Claim(ClaimTypes.Role,Role)

            };

            await _userManager.AddClaimsAsync(newEmployee,Claims);
            return Ok(Result);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<TokenDTO>> Login (LoginDTO loginDTO)
        {
            var user= await _userManager.FindByEmailAsync(loginDTO.Email);
            if (user == null) return NotFound();

            var isAuthenticated = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
            if(!isAuthenticated) { return Unauthorized(); }


            var Claims = await _userManager.GetClaimsAsync(user);

            var secretKeyString = _configuration.GetValue<string>("SecretKey") ?? string.Empty;
            var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKeyString);
            var secretKey = new SymmetricSecurityKey(secretKeyInBytes);

            //Combination SecretKey, HashingAlgorithm
            var siginingCreedentials = new SigningCredentials(secretKey,
                SecurityAlgorithms.HmacSha256Signature);

            var Expirydate = DateTime.Now.AddDays(1);

            var token = new JwtSecurityToken(
                claims: Claims,
                expires: Expirydate,
                signingCredentials: siginingCreedentials);

            var TokenHandler= new JwtSecurityTokenHandler();
            var TokenString =TokenHandler.WriteToken(token);

            return new TokenDTO() { Token=TokenString,Expiry=Expirydate};


        }

    }
}
