using Activity4FrontendApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Activity4FrontendApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<PortfolioProject> PortfolioProjects { get; set; }
    }
}