using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using WebApplication1.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UserContext>(Options=>
Options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityCon")));


#region Identity Managers

builder.Services.AddIdentity<Employee, IdentityRole>(options =>
{
    options.Password.RequiredUniqueChars = 3;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;

    options.User.RequireUniqueEmail = true;
})
    .AddEntityFrameworkStores<UserContext>();

#endregion

builder.Services.AddAuthentication(Options =>
{
    Options.DefaultAuthenticateScheme = "Authentication";
    Options.DefaultChallengeScheme = "Authentication";

}).AddJwtBearer("Authentication", Options =>
{
    var secretKeyString = builder.Configuration.GetValue<string>("SecretKey") ?? string.Empty;
    var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKeyString);
    var secretKey = new SymmetricSecurityKey(secretKeyInBytes);

    Options.TokenValidationParameters = new TokenValidationParameters
    {
        IssuerSigningKey = secretKey,
        ValidateIssuer = false,
        ValidateAudience = false,
    };
});

#region Authorization

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AllowUser", policy => policy
        .RequireClaim(ClaimTypes.Role, "User")
        .RequireClaim(ClaimTypes.NameIdentifier));

    options.AddPolicy("AllowManagers", policy => policy
        .RequireClaim(ClaimTypes.Role, "Management"));
});

#endregion


#region Cors

var corsPolicy = "AllowAll";
builder.Services.AddCors(options =>
{
    options.AddPolicy(corsPolicy, p => p.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod());
});

#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseCors(corsPolicy);
app.UseAuthorization();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
