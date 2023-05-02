using Microsoft.EntityFrameworkCore;
using SharedLibrary;

namespace MyAPI.Model
{
    public class MainDbContext :DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
    }
}
