using Microsoft.EntityFrameworkCore;
using Profil_Osobowosci.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Profil_Osobowosci.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<PersonalityTestResult> PersonalityTestResults { get; set; }
        public DbSet<ModelOutput> ModelOutputs { get; set; }
    }
}