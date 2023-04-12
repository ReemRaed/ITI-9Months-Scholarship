using Microsoft.EntityFrameworkCore;
using Reservation.BL.Managers;
using Reservation.DAL;
using Reservation.DAL.Data.Context;
using Reservation.DAL.Repos.Ticket;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("ReservationCon");
builder.Services.AddDbContext<ReservationContext>(options
    => options.UseSqlServer(connectionString));
#region Repos

builder.Services.AddScoped<ITicketRepo, TicketRepo>();
builder.Services.AddScoped<IDeveloperRepo, DeveloperRepo>();
builder.Services.AddScoped<IDepartemntRepo, DepartemntRepo>();



#endregion

#region Managers

builder.Services.AddScoped<ITicketManager, TicketManager>();
builder.Services.AddScoped<IDeveloperManager, DeveloperManager>();
builder.Services.AddScoped<IDepartmentManager, DepartmentManager>();



#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
