using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebApplication1.Data;

    public class Employee:IdentityUser
    {

    public string Department { get; set; } = string.Empty;

    }

