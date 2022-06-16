using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using COMP2084_BugTracker.Models;

namespace COMP2084_BugTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<COMP2084_BugTracker.Models.Project>? Project { get; set; }
        public DbSet<COMP2084_BugTracker.Models.Bug>? Bug { get; set; }
    }
}