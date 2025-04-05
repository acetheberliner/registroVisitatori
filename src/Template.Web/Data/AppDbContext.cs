using Microsoft.EntityFrameworkCore;
using Template.Web.Models;

namespace Template.Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Visitatore> Visitatori { get; set; }
    }
}
