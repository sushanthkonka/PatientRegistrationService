using Microsoft.EntityFrameworkCore;
using PatientRegistrationService.Models;

namespace PatientRegistrationService.Data 
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; } 
    }
}
