using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace COMP2084_BugTracker.Data
{
    public class AppContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] arg)

        {
            var optBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optBuilder.UseSqlServer("Server=tcp:comp2084dan.database.windows.net,1433;Initial Catalog=COMP2084-BugTracker;Persist Security Info=False;User ID=DVolchok;Password=Upyour@$$123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            return new ApplicationDbContext(optBuilder.Options); 
        }
    }
}
