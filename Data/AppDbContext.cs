using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace MSSQLApp.Data
{

    
    public class AppDbContext : DbContext
    {
        public IConfiguration _config { get; set; }
        public AppDbContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
