using Microsoft.EntityFrameworkCore;
using TestAssignmentRiskStrategy.Model.Entities;

namespace TestAssignmentRiskStrategy.Model
{
    public class ApplicationContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<State> Statements { get; set; }
        public DbSet<History> Historys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5432;Database=RiskStrategyDb;Username=postgres;Password=1234567");
        }
    }
}
