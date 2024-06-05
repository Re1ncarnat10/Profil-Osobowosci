using Microsoft.EntityFrameworkCore;
using Profil_Osobowosci.Models;

namespace Profil_Osobowosci.AppDbConext;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<PersonalityTestResult> PersonalityTestResults { get; set; }
}