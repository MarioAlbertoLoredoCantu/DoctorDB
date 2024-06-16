using Microsoft.EntityFrameworkCore;
using Tdoctor.Entities;

namespace Tdoctor
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }

 public DbSet<Doctor> Doctors { get; set;}
 public DbSet<Especialidad> Especialidades { get; set;}

        
        
        
    }
}